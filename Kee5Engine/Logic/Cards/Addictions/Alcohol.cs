using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class Alcohol : Addiction
    {
        public Alcohol(Vector2 position, bool front, int playerID) : base("Alcohol", position, front, playerID, Category.ALCOHOL)
        {

        }
    }
}
