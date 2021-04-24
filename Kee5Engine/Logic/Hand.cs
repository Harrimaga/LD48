using System;
using System.Collections.Generic;
using System.Text;
using LD48.Logic.Cards;
using OpenTK.Mathematics;

namespace LD48.Logic
{
    public class Hand
    {
        private List<Card> cards;
        private int playerID, handLimit;

        public Hand(int playerID)
        {
            this.playerID = playerID;
            cards = new List<Card>();
            handLimit = 7;
        }

        public void Update(double delta)
        {

        }

        public void Draw()
        {
            foreach (Card card in cards)
            {
                card.Draw();
            }
        }

        public bool CheckForSpace()
        {
            return cards.Count < handLimit;
        }

        public bool AddCardToHand(Card card)
        {
            if (cards.Count == handLimit)
            {
                return false;
            }

            cards.Add(card);
            card.SetPosition(new Vector2(100 + cards.Count * 150, 900 - 700 * playerID));

            return true;
        }

    }
}
