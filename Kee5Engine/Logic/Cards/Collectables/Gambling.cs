using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Collectables
{
    public class Gambling : Collectable
    {

        private static string[] names = new string[] { "Poker", "BlackJack", "Roulette", "Lottery", "Slotmachines", "Betting" };

        public Gambling(Vector2 position, bool front, int playerID, string type = null) : base(type == null ? names[Globals.r.Next(names.Length)] : type, position, front, playerID)
        {
            categories.Add(Category.GAMBLING);
        }

        public override void Activate()
        {
            if(Globals.r.NextDouble() < Balance.gamblingChance)
            {
                Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(-Balance.gamblingPayout);
            }
            base.Activate();
        }

    }
}
