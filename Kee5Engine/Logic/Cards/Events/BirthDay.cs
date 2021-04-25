using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Birthday : Event
    {
        public Birthday(Vector2 position, bool front) : base("Birthday", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(-Balance.BirtdayAmount);
            Globals.gameHandler.GetPlayerFromID((playerID + 1)%2).AddDebt(Balance.BirtdayAmount);
        }
    }
}
