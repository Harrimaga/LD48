using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Influencer : Income
    {

        public Influencer(Vector2 position, bool front, int playerID) : base("Influencer", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeHigh;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.influencerTravel);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(Balance.influencerInternet);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.influencerTravel);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(-Balance.influencerInternet);
            base.OnLeave();
        }
    }
}