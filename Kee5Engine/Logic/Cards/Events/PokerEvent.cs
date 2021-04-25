using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LD48.Logic.Cards.Collectables;

namespace LD48.Logic.Cards.Events
{
    public class PokerEvent : Event
    {

        private static string[] names = new string[] { "Poker", "BlackJack", "Roulette", "Lottery", "Slotmachines", "Betting" };

        private string type;

        public PokerEvent(Vector2 position, bool front) : base(names[Globals.r.Next(names.Length)] + " Event", position, front, -1)
        {
            type = name.Remove(name.IndexOf(" "));
        }

        public override void OnEnter(int playerID)
        {
            if(Globals.r.NextDouble() < Balance.EventGamblingChance)
            {
                Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.EventGamblingWin);
            }
            else
            {
                Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.EventGamblingLoss);
            }
            Card c = new Gambling(Vector2.Zero, true, playerID, type);
            Globals.cardSelected = c;
            Globals.gameHandler.gameBoard.PlayCardOnField(playerID, playerID == 0 ? Globals.gameHandler.gameBoard.playingField1 : Globals.gameHandler.gameBoard.playingField2);
            Globals.cardSelected = null;
        }
    }
}
