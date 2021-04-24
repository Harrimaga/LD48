using LD48.Logic.Cards;
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
        private Texture bg = Window.textures.GetTexture("Pixel");

        private Button endTurn = new Button(1800, 1010, 200, 100, 10f, "Pixel", new Vector4(0.1f, 0.7f, 0.3f, 1), true, () => { Globals.gameHandler.EndTurn(); });

        public Board()
        {
            Globals.activeButtons.Add(endTurn);
            income1 = new List<Card>();
            income2 = new List<Card>();
            playingField1 = new List<Card>();
            playingField2 = new List<Card>();
        }

        public void Update(double delta)
        {

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
            else
            {

            }


            return false;
        }

        public void BeginTurn(int player)
        {
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

            endTurn.Draw();
        }
    }
}
