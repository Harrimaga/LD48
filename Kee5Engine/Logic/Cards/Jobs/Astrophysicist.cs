﻿using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class Astrophysicist : Income
    {

        public Astrophysicist(Vector2 position, bool front, int playerID) : base("Astrophysicist", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeHigh;
        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.astrophysicistTravel);
            Globals.gameHandler.GetPlayerFromID(playerID).AddHousing(Balance.astrophysicistHousing);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(-Balance.astrophysicistTravel);
            Globals.gameHandler.GetPlayerFromID(playerID).AddHousing(-Balance.astrophysicistHousing);
            base.OnLeave();
        }
    }
}