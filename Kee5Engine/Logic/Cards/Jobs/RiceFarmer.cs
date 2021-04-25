using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class RiceFarmer : Income
    {

        public RiceFarmer(Vector2 position, bool front, int playerID) : base("Rice Farmer", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeLow;
        }

    }
}
