using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class BusDriver : Income
    {

        public BusDriver(Vector2 position, bool front, int playerID) : base("Bus Driver", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeMhe;
        }

    }
}