using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Concert : Event
    {
        public Concert(Vector2 position, bool front) : base("Concert", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.ConcertCost);
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.ConcertHappiness);
        }
    }
}
