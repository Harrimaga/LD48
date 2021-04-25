using LD48.Logic.Cards.Collectables;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Party : Event
    {
        public Party(Vector2 position, bool front) : base("Party", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.PartyCost);
            do
            {
                Card c;
                if(Globals.r.Next(2) == 0)
                {
                    c = new Drugs(Vector2.Zero, true, playerID);
                }
                else
                {
                    c = new Alcohol(Vector2.Zero, true, playerID);
                }
                Globals.cardSelected = c;
                Globals.gameHandler.gameBoard.PlayCardOnField(playerID, playerID == 0 ? Globals.gameHandler.gameBoard.playingField1 : Globals.gameHandler.gameBoard.playingField2);
                Globals.cardSelected = null;

            } while (Globals.r.NextDouble() < Balance.PartyChance);
        }
    }
}
