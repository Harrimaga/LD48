using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Shanked : Event
    {
        public Shanked(Vector2 position, bool front) : base("Shanked", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            if(Globals.r.NextDouble() < Balance.ShankedChance)
            {
                Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.ShankedAmount);
            }
            
        }
    }
}
