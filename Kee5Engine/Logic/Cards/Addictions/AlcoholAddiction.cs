using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class AlcoholAddiction : Addiction
    {
        public AlcoholAddiction(Vector2 position, bool front, int playerID) : base("Alcohol", position, front, playerID, Category.ALCOHOL)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.alcoholHappiness);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(-Balance.alcoholHappiness);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.alcoholCosts);
            base.Activate();
        }

    }
}
