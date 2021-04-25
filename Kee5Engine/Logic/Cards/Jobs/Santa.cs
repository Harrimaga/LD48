using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Santa : Income
    {

        public Santa(Vector2 position, bool front, int playerID) : base("Santa", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            if(Globals.r.Next(5) == 0)
            {
                return Balance.incomeHigh;
            }
            return 0;
        }
    }
}