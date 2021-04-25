using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Fired : Event
    {
        public Fired(Vector2 position, bool front) : base("Fired", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.gameBoard.Fire(playerID);
        }
    }
}
