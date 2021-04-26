using LD48.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.AI
{
    public class BasicAI
    {
        public double timer;
        public BasicAI()
        {
            timer = Globals.r.Next(1, 3);
        }

        public void DoTurn()
        {
            int r = Globals.r.Next(0, 3);

            switch (r)
            {
                case 0:
                    DrawCard();
                    break;
                case 1:
                    PlayCard();
                    break;
                case 2:
                    EndTurn();
                    break;
            }

            timer = Globals.r.Next(1, 4);
        }

        public void DrawCard()
        {
            Globals.gameHandler.player2.DrawCard();
        }

        public void PlayCard()
        {
            List<Card> hand = Globals.gameHandler.player2.hand.GetHand();

            if (hand.Count == 0)
            {
                DrawCard();
                return;
            }

            Card card = hand[Globals.r.Next(0, hand.Count)];
            

            if (card is Income)
            {
                if (Globals.gameHandler.gameBoard.PlayCard(card, 1))
                {
                    card.Flip();
                }
            }
            else
            {
                Globals.cardSelected = card;
                card.Flip();
                int r = Globals.r.Next(0, 2);
                List<Card> field = r == 0 ? Globals.gameHandler.gameBoard.playingField1 : Globals.gameHandler.gameBoard.playingField2;
                
                Globals.gameHandler.gameBoard.PlayCardOnField(r, field);
            }
        }

        public void EndTurn()
        {
            Globals.gameHandler.gameBoard.HandleEvent(Globals.gameHandler.gameBoard.closed[0]);
        }

        public void Activate(double delta)
        {
            timer -= delta;
            if (timer <= 0)
            {
                DoTurn();
            }
        }
    }
}
