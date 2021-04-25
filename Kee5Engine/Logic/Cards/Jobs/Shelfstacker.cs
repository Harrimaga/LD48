using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Shelfstacker : Income
    {

        public Shelfstacker(Vector2 position, bool front, int playerID) : base("Shelf Stacker", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeLow;
        }

    }
}
