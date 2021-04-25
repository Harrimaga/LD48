using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Conman : Income
    {

        public Conman(Vector2 position, bool front, int playerID) : base("Conman", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            Globals.gameHandler.GetPlayerFromID((playerID + 1) % 2).AddDebt(Balance.ModifyIncome(Balance.incomeMhe, Globals.gameHandler.GetPlayerFromID(playerID).GetHappiness()));
            return Balance.incomeMhe;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(Balance.conmanIllegal);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(-Balance.conmanIllegal);
            base.OnLeave();
        }
    }
}