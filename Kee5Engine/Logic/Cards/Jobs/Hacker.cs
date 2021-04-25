using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Hacker : Income
    {

        public Hacker(Vector2 position, bool front, int playerID) : base("Hacker", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            int rn = Globals.r.Next(4);
            switch(rn)
            {
                case 0:
                    return Balance.incomeLow;
                case 1:
                    return Balance.incomeMhe;
                case 2:
                    return Balance.incomeHigh;
            }
            return 0;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(Balance.hackerIllegal);
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(Balance.hackerElectricity);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(Balance.hackerInternet);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(-Balance.hackerIllegal);
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(-Balance.hackerElectricity);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(-Balance.hackerInternet);
            base.OnLeave();
        }
    }
}