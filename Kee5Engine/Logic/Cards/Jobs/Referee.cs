using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Referee : Income
    {

        public Referee(Vector2 position, bool front, int playerID) : base("Referee", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeLow;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.refereeTravel);
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.refereeHappiness);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.refereeTravel);
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(-Balance.refereeHappiness);
            base.OnLeave();
        }
    }
}