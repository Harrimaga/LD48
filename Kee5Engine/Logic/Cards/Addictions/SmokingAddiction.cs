using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class SmokingAddiction : Addiction
    {
        public SmokingAddiction(Vector2 position, bool front, int playerID) : base("Smoking", position, front, playerID, Category.SMOKING)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.smokingHappiness);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(-Balance.smokingHappiness);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.smokingCosts);
            base.Activate();
        }

    }
}
