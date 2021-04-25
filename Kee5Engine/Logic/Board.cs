using LD48.Logic.Cards;
using LD48.Logic.Cards.Addictions;
using LD48.Logic.Cards.Events;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic
{
    public class Board
    {
        public List<Card> playingField1, playingField2;
        public List<Card> income1, income2;
        public List<Event> closed, open;
        private Texture bg = Window.textures.GetTexture("Pixel");

        private double time = 0;

        private Button topField;
        private Button bottomField;

        public Board()
        {
            income1 = new List<Card>();
            income2 = new List<Card>();
            playingField1 = new List<Card>();
            playingField2 = new List<Card>();
            closed = new List<Event>();
            open = new List<Event>();
            topField = new Button(1135, 390, 1570, 300, 2f, "Pixel", new Vector4(1, 1, 1, 0), true, () => { PlayCardOnField(1, playingField2); });
            bottomField = new Button(1135, 690, 1570, 300, 2f, "Pixel", new Vector4(1, 1, 1, 0), true, () => { PlayCardOnField(0, playingField1); });
            Globals.activeButtons.Add(topField);
            Globals.activeButtons.Add(bottomField);

            FillEventDeck();
        }

        public void Update(double delta)
        {
            if (Globals.cardSelected != null)
            {
                time += delta;
                topField.SetBackground(new Vector4(1, 0.8f, 1, (float)Math.Abs(Math.Sin(time) * 0.2f)));
                bottomField.SetBackground(new Vector4(0.8f, 1, 1, (float)Math.Abs(Math.Sin(time) * 0.2f)));
            }
            else
            {
                topField.SetBackground(new Vector4(1, 0.8f, 1, 0));
                bottomField.SetBackground(new Vector4(0.8f, 1, 1, 0));
                time = 0;
            }
        }

        public void PlayCardOnField(int fieldi, List<Card> field)
        {
            if (Globals.cardSelected == null)
            {
                return;
            }
            Globals.cardSelected.SetState(CardState.BOARD);
            field.Add(Globals.cardSelected);
            Globals.gameHandler.GetPlayerFromID(Globals.cardSelected.playerID).hand.RemoveCardFromHand(Globals.cardSelected);
            Globals.cardSelected.OnEnter(fieldi);
            CheckAddAddiction(fieldi, field);

            Globals.cardSelected = null;
            ResetPositionsField(fieldi, field);

            Globals.gameHandler.GetPlayerFromID(0).ChangeTexts();
            Globals.gameHandler.GetPlayerFromID(1).ChangeTexts();
        }

        public void FillEventDeck()
        {
            for (int i = 0; i < Balance.maxTurns * 2; i++)
            {
                closed.Add(new GoToStart(new Vector2(1800 + 0.47362f * i, 480 + 0.47362f * i), false));
            }
            closed[0].SetActive();
        }

        public void HandleEvent(Event card)
        {
            card.Activate();
            card.OnEnter((int)Globals.gameHandler.state);

            closed.RemoveAt(0);
            if (closed.Count > 0)
            {
                closed[0].SetActive();
            }

            open.Add(card);
            card.Flip();
            card.SetRotation(90);
            open.Reverse();

            card.SetPosition(new Vector2(1800 + 0.47362f * 20 - 0.47362f * (open.Count - 1), 590 + 0.47362f * 20 - 0.47362f * (open.Count - 1)));

            Globals.gameHandler.EndTurn();
        }

        public void CheckAddAddiction(int fieldi, List<Card> field)
        {
            Collectable card = (Collectable)Globals.cardSelected;

            foreach (Category cat in card.GetCategories())
            {
                int addictNum = 0;
                foreach (Card c in field)
                {
                    if (c is Addiction)
                    {
                        if (((Addiction)c).GetCategory() == cat)
                        {
                            addictNum = 0;
                            break;
                        }
                    }

                    if (c is Collectable)
                    {
                        if (((Collectable)c).GetCategories().Contains(cat))
                        {
                            addictNum++;
                        }
                    }
                }

                if (Balance.IsAddiction(cat, addictNum))
                {
                    Card addiction = AddAddiction(fieldi, cat);
                    field.Add(addiction);
                    addiction.OnEnter(fieldi);

                    for (int i = field.Count - 1; i >= 0; i--)
                    {
                        if (field[i] is Collectable)
                        {
                            if (((Collectable)field[i]).GetCategories().Contains(cat))
                            {
                                ((Collectable)field[i]).OnLeave();
                                field.RemoveAt(i);
                            }
                        }
                    }
                }

            }
        }

        public Card AddAddiction(int fieldi, Category cat)
        {
            switch (cat)
            {
                case Category.ALCOHOL:
                    return new AlcoholAddiction(Vector2.Zero, true, fieldi);
                case Category.DRUGS:
                    return new DrugsAddiction(Vector2.Zero, true, fieldi);
                case Category.EATINGOUT:
                    return new EatingOutAddiction(Vector2.Zero, true, fieldi);
                case Category.FASTFOOD:
                    return new FastFoodAddiction(Vector2.Zero, true, fieldi);
                case Category.GAMBLING:
                    return new GamblingAddiction(Vector2.Zero, true, fieldi);
                case Category.GAMING:
                    return new GamingAddiction(Vector2.Zero, true, fieldi);
                case Category.POM_XML:
                    return new PomXMLAddiction(Vector2.Zero, true, fieldi);
                case Category.SHOPPING:
                    return new ShoppingAddiction(Vector2.Zero, true, fieldi);
                case Category.SMOKING:
                    return new SmokingAddiction(Vector2.Zero, true, fieldi);
                case Category.SOCIALMEDIA:
                    return new SocialMediaAddiction(Vector2.Zero, true, fieldi);
                case Category.STREAMING:
                    return new StreamingAddiction(Vector2.Zero, true, fieldi);

            }
            return null;
        }

        public void ResetPositionsField(int field, List<Card> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                cards[i].SetPosition(new Vector2(1135 - (cards.Count - 1) * 55 + i * 110, 690 - 300 * field));
            }
        }

        public bool PlayCard(Card card, int side)
        {
            if (card is Income)
            {
                if (card.playerID == side)
                {
                    List<Card> cards = side == 0 ? income1 : income2;

                    if (cards.Count < 2)
                    {
                        cards.Add(card);
                        card.SetPosition(new Vector2(400 + 110 * cards.Count - 50, 690 - 300 * side));
                        Globals.gameHandler.GetPlayerFromID(card.playerID).hand.RemoveCardFromHand(card);
                        return true;
                    }
                }
            }
            else if (card is Collectable)
            {
                ((Collectable)card).StartSelection();
            }


            return false;
        }

        public void BeginTurn(int player)
        {
            Globals.cardSelected = null;
            List<Card> cards = player == 0 ? playingField1 : playingField2;
            foreach (Card c in cards)
            {
                c.Activate();
            }
            cards = player == 0 ? income1 : income2;
            foreach (Card c in cards)
            {
                c.Activate();
            }
        }

        public void Draw()
        {
            // Decks
            Window.spriteRenderer.DrawSprite(bg, new Vector2(175, 270), new Vector2(350, 540), 3, 0, new Vector4(0.5f, 0.5f, 0.5f, 1));
            Window.spriteRenderer.DrawSprite(bg, new Vector2(175, 810), new Vector2(350, 540), 3, 0, new Vector4(0.2f, 0.2f, 0.2f, 1));

            // Hands
            Window.spriteRenderer.DrawSprite(bg, new Vector2(1135, 120), new Vector2(1570, 240), 3, 0, new Vector4(0.5f, 0.7f, 0.5f, 1));
            Window.spriteRenderer.DrawSprite(bg, new Vector2(1135, 960), new Vector2(1570, 240), 3, 0, new Vector4(0.2f, 0.4f, 0.2f, 1));

            topField.Draw();
            bottomField.Draw();

            foreach (Card card in income1)
            {
                card.Draw();
            }

            foreach (Card card in income2)
            {
                card.Draw();
            }

            foreach (Card card in playingField1)
            {
                card.Draw();
            }

            foreach (Card card in playingField2)
            {
                card.Draw();
            }

            foreach (Card card in closed)
            {
                card.Draw();
            }

            foreach (Card card in open)
            {
                card.Draw();
            }
        }
    }
}
