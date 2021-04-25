using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class TaxiDriver : Income
    {

        public TaxiDriver(Vector2 position, bool front, int playerID) : base("TaxiDriver", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeMhe;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.taxiDriverTravel);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.taxiDriverTravel);
            base.OnLeave();
        }
    }
}