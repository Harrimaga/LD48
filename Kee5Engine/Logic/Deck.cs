using LD48.Logic.Cards;
using LD48.Logic.Cards.Collectables;
using LD48.Logic.Cards.Jobs;
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
            if (Globals.r.Next(3) == 0)
            {
                int cardsCount = 32;
                int rn = Globals.r.Next(cardsCount);
                switch(rn)
                {
                    case 0:
                        c = new Actor(position, front, playerID);
                        break;
                    case 1:
                        c = new Artist(position, front, playerID);
                        break;
                    case 2:
                        c = new Astrophysicist(position, front, playerID);
                        break;
                    case 3:
                        c = new Babysitter(position, front, playerID);
                        break;
                    case 4:
                        c = new BabysitterU(position, front, playerID);
                        break;
                    case 5:
                        c = new BusDriver(position, front, playerID);
                        break;
                    case 6:
                        c = new Conman(position, front, playerID);
                        break;
                    case 7:
                        c = new DeliveryPerson(position, front, playerID);
                        break;
                    case 8:
                        c = new DrugDealer(position, front, playerID);
                        break;
                    case 9:
                        c = new FastFoodEmployee(position, front, playerID);
                        break;
                    case 10:
                        c = new Hacker(position, front, playerID);
                        break;
                    case 11:
                        c = new Hitman(position, front, playerID);
                        break;
                    case 12:
                        c = new HumanTrafficker(position, front, playerID);
                        break;
                    case 13:
                        c = new IndieGameDev(position, front, playerID);
                        break;
                    case 14:
                        c = new Influencer(position, front, playerID);
                        break;
                    case 15:
                        c = new InstaModel(position, front, playerID);
                        break;
                    case 16:
                        c = new InternDev(position, front, playerID);
                        break;
                    case 17:
                        c = new JuniorDev(position, front, playerID);
                        break;
                    case 18:
                        c = new Musician(position, front, playerID);
                        break;
                    case 19:
                        c = new OnlyFans(position, front, playerID);
                        break;
                    case 20:
                        c = new Referee(position, front, playerID);
                        break;
                    case 21:
                        c = new RiceFarmer(position, front, playerID);
                        break;
                    case 22:
                        c = new Santa(position, front, playerID);
                        break;
                    case 23:
                        c = new Shelfstacker(position, front, playerID);
                        break;
                    case 24:
                        c = new Shoplifter(position, front, playerID);
                        break;
                    case 25:
                        c = new Sporter(position, front, playerID);
                        break;
                    case 26:
                        c = new StartupCEO(position, front, playerID);
                        break;
                    case 27:
                        c = new Streamer(position, front, playerID);
                        break;
                    case 28:
                        c = new SugarDaddy(position, front, playerID);
                        break;
                    case 29:
                        c = new TaxiDriver(position, front, playerID);
                        break;
                    case 30:
                        c = new Writer(position, front, playerID);
                        break;
                    case 31:
                        c = new YogaInstructor(position, front, playerID);
                        break;
                }
            }
            else
            {
                int cardsCount = 13;
                int rn = Globals.r.Next(cardsCount);
                switch (rn)
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
            }

            return c;
        }

    }
}
