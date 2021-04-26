using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class Joint : Collectable
    {

        private static string[] names = new string[] { "Jonko" };

        public Joint(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.SMOKING);
            categories.Add(Category.DRUGS);
        }

    }
}
