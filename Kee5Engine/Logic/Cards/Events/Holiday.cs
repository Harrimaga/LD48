using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Holiday : Event
    {
        public Holiday(Vector2 position, bool front) : base("Holiday", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.HolidayCost);
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.HolidayHappiness);
            Globals.gameHandler.GetPlayerFromID(playerID).AddTravel(Balance.HolidayTravel);
        }
    }
}
