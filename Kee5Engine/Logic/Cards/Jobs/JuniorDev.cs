using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class JuniorDev : Income
    {

        public JuniorDev(Vector2 position, bool front, int playerID) : base("Junior Dev", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeMhe;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(Balance.juniorDevElectricity);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(-Balance.juniorDevElectricity);
            base.OnLeave();
        }
    }
}