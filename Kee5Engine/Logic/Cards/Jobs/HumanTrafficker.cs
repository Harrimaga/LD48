using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class HumanTrafficker : Income
    {

        public HumanTrafficker(Vector2 position, bool front, int playerID) : base("HumanTrafficker", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeHigh;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(Balance.humanTraffickerIllegal);
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.humanTraffickerTravel);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(-Balance.humanTraffickerIllegal);
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.humanTraffickerTravel);
            base.OnLeave();
        }
    }
}