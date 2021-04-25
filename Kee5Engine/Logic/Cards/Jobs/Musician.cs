using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Musician : Income
    {

        public Musician(Vector2 position, bool front, int playerID) : base("Musician", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return 0;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.musicianHappiness);
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(Balance.musicianElectricity);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(-Balance.musicianHappiness);
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(-Balance.musicianElectricity);
            base.OnLeave();
        }
    }
}