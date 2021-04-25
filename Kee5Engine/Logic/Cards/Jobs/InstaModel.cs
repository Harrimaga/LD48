using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class InstaModel : Income
    {

        public InstaModel(Vector2 position, bool front, int playerID) : base("Insta Model", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeHigh;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.instaModelTravel);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.instaModelTravel);
            base.OnLeave();
        }
    }
}