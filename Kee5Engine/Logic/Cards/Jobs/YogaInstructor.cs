using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class YogaInstructor : Income
    {

        public YogaInstructor(Vector2 position, bool front, int playerID) : base("YogaInstructor", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeHigh;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHousing(Balance.yogaHousing);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHousing(-Balance.yogaHousing);
            base.OnLeave();
        }
    }
}