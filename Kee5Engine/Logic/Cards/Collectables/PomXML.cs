using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class PomXML : Collectable
    {

        private static string[] names = new string[] { "Pomhub.xml", "HentaiHaven", "Playboy Magazine", "Only-Fans subscribtion", "\"Calenders\"" };

        public PomXML(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.POM_XML);
        }

    }
}
