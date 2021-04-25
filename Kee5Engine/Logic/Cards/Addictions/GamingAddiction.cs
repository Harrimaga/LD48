using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class GamingAddiction : Addiction
    {
        public GamingAddiction(Vector2 position, bool front, int playerID) : base("Gaming", position, front, playerID, Category.GAMING)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(Balance.gamingElecticity);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(Balance.gamingElecticity);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(-Balance.gamingElecticity);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(-Balance.gamingElecticity);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.gamingCosts);
            base.Activate();
        }

    }
}