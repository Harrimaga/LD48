﻿using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class Streaming : Collectable
    {

        private static string[] names = new string[] { "Netflux", "Dasny+", "Ourtube", "Age BO", "Hooloo", "Cable" };

        public Streaming(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.STREAMING);
        }

    }
}
