using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class Gaming : Collectable
    {

        private static string[] names = new string[] { "Tetris", "Mario", "Deck Stack Puzzle Maniac", "Donkey Kong", "Space Invaders", "Pac-Man", "Survival on Feiv" };

        public Gaming(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.GAMING);
        }

    }
}
