using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Babysitter : Income
    {

        public Babysitter(Vector2 position, bool front, int playerID) : base("Babysitter", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeLow;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.babysitterHappiness);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(-Balance.babysitterHappiness);
            base.OnLeave();
        }
    }
}