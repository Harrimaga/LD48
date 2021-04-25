using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class GamblingAddiction : Addiction
    {
        public GamblingAddiction(Vector2 position, bool front, int playerID) : base("Gambling", position, front, playerID, Category.GAMBLING)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.gamblingTravel);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.gamblingTravel);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.gamblingCosts);
            if (Globals.r.NextDouble() < Balance.gamblingChance*5)
            {
                Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(-Balance.gamblingPayout);
            }
            base.Activate();
        }

    }
}