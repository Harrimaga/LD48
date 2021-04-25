using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class EatingOutAddiction : Addiction
    {
        public EatingOutAddiction(Vector2 position, bool front, int playerID) : base("Eating out", position, front, playerID, Category.EATINGOUT)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.eatingOutTravel);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.eatingOutTravel);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.eatingOutCosts);
            base.Activate();
        }

    }
}