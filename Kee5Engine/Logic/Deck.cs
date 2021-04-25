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
                cards.Add(RandomCard(new Vector2(100 + 0.47362f * i, 920 - 800 * playerID + 0.47362f * i), false, playerID));
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

        private Card RandomCard(Vector2 position, bool front, int playerID)
        {
            Card c = null;
            int cardsCount = 13;
            int rn = Globals.r.Next(cardsCount);
            switch(rn)
            {
                case 0:
                    c = new Alcohol(position, front, playerID);
                    break;
                case 1:
                    c = new Drugs(position, front, playerID);
                    break;
                case 2:
                    c = new EatingOut(position, front, playerID);
                    break;
                case 3:
                    c = new FastFood(position, front, playerID);
                    break;
                case 4:
                    c = new Gambling(position, front, playerID);
                    break;
                case 5:
                    c = new Gaming(position, front, playerID);
                    break;
                case 6:
                    c = new Joint(position, front, playerID);
                    break;
                case 7:
                    c = new PomXML(position, front, playerID);
                    break;
                case 8:
                    c = new Shopping(position, front, playerID);
                    break;
                case 9:
                    c = new Smoking(position, front, playerID);
                    break;
                case 10:
                    c = new SocialMedia(position, front, playerID);
                    break;
                case 11:
                    c = new Streaming(position, front, playerID);
                    break;
                case 12:
                    c = new VideoGames(position, front, playerID);
                    break;
            }

            return c;
        }

    }
}
