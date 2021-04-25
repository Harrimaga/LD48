using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class VideoGames : Collectable
    {

        private static string[] names = new string[] { "Video Games" };

        public VideoGames(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.GAMING);
            categories.Add(Category.SHOPPING);
        }

    }
}
