using LD48.Logic.Cards;
using LD48.Logic.Cards.Collectables;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic
{
    public class Deck
    {
        private List<Card> cards;
        private int playerID;

        public Deck(int id)
        {
            playerID = id;
            cards = new List<Card>();

            for (int i = 0; i < 60; i++)
            {
                cards.Add(new Alcohol(new Vector2(100 + 0.47362f * i, 920 - 800 * playerID + 0.47362f * i), false, playerID));
            }

            cards[0].SetActive();
        }

        public int GetCardsRemaining()
        {
            return cards.Count;
        }

        public void Update(double delta)
        {
            foreach (Card card in cards)
            {
                card.Update(delta);
            }
        }

        public void Draw()
        {
            foreach (Card card in cards)
            {
                card.Draw();
            }
        }

        public Card DrawCard()
        {
            if(cards.Count == 0)
            {
                return null;
            }
            Card card = cards[0];
            cards.RemoveAt(0);
            if (cards.Count > 0)
            {
                cards[0].SetActive();
            }
            return card;
        }

    }
}
