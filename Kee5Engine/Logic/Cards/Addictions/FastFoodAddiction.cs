using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class FastFoodAddiction : Addiction
    {
        public FastFoodAddiction(Vector2 position, bool front, int playerID) : base("FastFoodAddiction", position, front, playerID, Category.FASTFOOD)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.fastFoodTravel);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.fastFoodTravel);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.fastFoodCosts);
            base.Activate();
        }

    }
}