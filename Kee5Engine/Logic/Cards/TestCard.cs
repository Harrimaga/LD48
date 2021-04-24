using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards
{
    public class TestCard : Card
    {
        public TestCard(Vector2 position, bool front, int playerID) : base("Test", position, front, playerID)
        {

        }
    }
}
