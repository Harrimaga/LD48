using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards
{
    public abstract class Counter : Card
    {
        public Counter(string name, Vector2 position, bool front, int playerID) : base(name, position, front, playerID)
        {

        }
    }
}
