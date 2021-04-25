using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class InternDev : Income
    {

        public InternDev(Vector2 position, bool front, int playerID) : base("Intern Dev", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return 0;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(Balance.internDevElectricity);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(-Balance.internDevElectricity);
            base.OnLeave();
        }
    }
}