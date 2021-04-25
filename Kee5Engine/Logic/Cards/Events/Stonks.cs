using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Stonks : Event
    {
        public Stonks(Vector2 position, bool front) : base("Stonks", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            if (Globals.r.Next(2) == 0)
            {
                Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(-Balance.StonksMoney);
            }
            else
            {
                Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.StonksMoney);
            }
        }
    }
}
