using System;
using System.Collections.Generic;
using System.Text;
using LD48.Logic.Cards;

namespace LD48.Logic
{
    public class Player
    {

        private Hand hand;
        private Deck deck;
        private int debt = 0, doekoes = 100, playerID;

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

        public void DrawCard()
        {
            if(!hand.CheckForSpace())
            {
                return;
            }
            Card card = deck.DrawCard();

            hand.AddCardToHand(card);
            card.SetState(CardState.HAND);
        }

        public void Draw()
        {
            hand.Draw();
            deck.Draw();
        }
    }
}
