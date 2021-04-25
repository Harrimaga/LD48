using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class ShoppingAddiction : Addiction
    {
        public ShoppingAddiction(Vector2 position, bool front, int playerID) : base("Shopping", position, front, playerID, Category.SHOPPING)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.shoppingTravel);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.shoppingTravel);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.shoppingCosts);
            base.Activate();
        }

    }
}