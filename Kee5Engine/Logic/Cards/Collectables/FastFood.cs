using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class FastFood : Collectable
    {

        private static string[] names = new string[] { "Hamburger", "Bratwurst", "Fries", "Pizza", "Döner", "Frikadel Special", "Soda", "Kaassouffle", "Bitterballen" };

        public FastFood(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.FASTFOOD);
        }

    }
}
