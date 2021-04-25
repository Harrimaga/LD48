using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards
{
    public abstract class Income : Card
    {
        protected int income;

        public Income(string name, Vector2 position, bool front, int playerID) : base(name, position, front, playerID)
        {

        }

        public virtual int GetIncome()
        {
            return 0;
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(-GetIncome());
        }
    }
}
