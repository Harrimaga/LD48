using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class Drugs : Collectable
    {

        private static string[] names = new string[] { "Heroin", "Cocain", "Speed", "Ketamine", "Meth", "MDMA", "Nederwiet" };

        public Drugs(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.DRUGS);
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(Balance.drugsCollectableIllegal);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(-Balance.drugsCollectableIllegal);
            base.OnLeave();
        }

    }
}
