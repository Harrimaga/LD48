using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards
{
    public class TestCard : Collectable
    {
        public TestCard(Vector2 position, bool front, int playerID) : base("Test", position, front, playerID)
        {
            categories.Add(Category.ALCOHOL);
        }

        //public override int GetIncome()
        //{
        //    return 420;
        //}

    }
}
