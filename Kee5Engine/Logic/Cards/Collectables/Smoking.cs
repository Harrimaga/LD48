using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class Smoking : Collectable
    {

        private static string[] names = new string[] { "Cigar", "Cigarette", "Pipe", "Vape"};

        public Smoking(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.SMOKING);
        }

    }
}
