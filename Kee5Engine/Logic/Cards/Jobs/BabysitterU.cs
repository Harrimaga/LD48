using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class BabysitterU : Income
    {

        public BabysitterU(Vector2 position, bool front, int playerID) : base("Babysitter (undeclared)", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeMhe;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.babysitterHappiness);
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(Balance.babysitterUIllegal);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(-Balance.babysitterHappiness);
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(-Balance.babysitterUIllegal);
            base.OnLeave();
        }
    }
}