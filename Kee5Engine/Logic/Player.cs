using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using LD48.Logic.Cards;
using LD48;
using OpenTK.Mathematics;

namespace LD48.Logic
{
    public class Player
    {

        public Hand hand;
        private Deck deck;
        private int debt = 0, playerID, cardsDrawn, housing = 0, electicity = 0, internet = 0, travel = 0, illegal = 0;

        public Player(int id)
        {
            hand = new Hand(id);
            deck = new Deck(id);
            playerID = id;
        }

        public void Update(double delta)
        {
            hand.Update(delta);
            deck.Update(delta);
        }

        public void BeginTurn()
        {
            cardsDrawn = 0;
        }

        public int getDebt()
        {
            return debt;
        }

        public void DrawCard()
        {
            if (!hand.CheckForSpace())
            {
                return;
            }
            Card card = deck.DrawCard();

            hand.AddCardToHand(card);
            card.Flip();
            card.SetState(CardState.HAND);

            cardsDrawn++;
            debt += Balance.GetDrawCost(cardsDrawn);
        }

        public void Draw()
        {
            hand.Draw();
            deck.Draw();

            Window.textRenderer.SetSize(24);

            Bitmap text = Window.textRenderer.RenderString($"Debt: {((float)debt /*/ 100*/)}", Color.Black);
            Bitmap textDeck = Window.textRenderer.RenderString($"Cards left: {deck.GetCardsRemaining()}", Color.Black);
            Bitmap textCost = Window.textRenderer.RenderString($"Cost: {Balance.GetDrawCost(cardsDrawn + 1)}", Color.Black);

            Texture textTex = Window.textures.LoadTexture(text, $"DebtPlayer{playerID}Text");
            Texture deckTex = Window.textures.LoadTexture(textDeck, $"DeckPlayer{playerID}Text");
            Texture costTex = Window.textures.LoadTexture(textCost, $"CostPlayer{playerID}Text");

            Window.spriteRenderer.DrawSprite(textTex, new Vector2(175, 590 - 300 * playerID), textTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(deckTex, new Vector2(175, 630 - 300 * playerID), deckTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(costTex, new Vector2(175, 670 - 300 * playerID), costTex.Size, 5f, 0, Vector4.One);
        }
    
        public void AddDebt(int amount)
        {
            debt += amount;
        }
    
    }
}
