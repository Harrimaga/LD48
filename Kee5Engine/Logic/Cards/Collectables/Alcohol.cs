using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class Alcohol : Collectable
    {

        private static string[] names = new string[] { "Beer", "Wine", "Whiskey", "Vodka", "Rum", "Champagne", "Port" };

        public Alcohol(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.ALCOHOL);
        }

    }
}
