using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class EatingOut : Collectable
    {

        private static string[] names = new string[] { "Carpaccio", "Beef", "Risotto", "Soup", "Salad", "Pokebowl", "Lasagne" };

        public EatingOut(Vector2 position, bool front, int playerID) : base(names[Globals.r.Next(names.Length)], position, front, playerID)
        {
            categories.Add(Category.EATINGOUT);
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.baseCollectableCost);
            base.Activate();
        }

    }
}
