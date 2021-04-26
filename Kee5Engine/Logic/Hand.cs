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

        public List<Card> GetHand()
        {
            return cards;
        }

        public bool AddCardToHand(Card card)
        {
            if (cards.Count == handLimit)
            {
                return false;
            }

            card.SetPosition(new Vector2(440 + cards.Count * 150, 960 - 840 * playerID));
            cards.Add(card);

            return true;
        }

        public void RemoveCardFromHand(Card card)
        {
            cards.Remove(card);
            int i = 0;
            foreach(Card c in cards)
            {
                c.SetPosition(new Vector2(440 + i * 150, 960 - 840 * playerID));
                i++;
            }
        }

    }
}
