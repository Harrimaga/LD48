using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Popo : Event
    {
        public Popo(Vector2 position, bool front) : base("Popo", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.GetPopoCost(Globals.gameHandler.GetPlayerFromID(playerID).GetIllegal()));
        }
    }
}
