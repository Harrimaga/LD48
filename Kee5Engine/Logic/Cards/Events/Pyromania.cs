using LD48.Logic.Cards.Addictions;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards.Events
{
    public class Pyromania : Event
    {
        public Pyromania(Vector2 position, bool front) : base("Pyromania", position, front, -1)
        {

        }

        public override void OnEnter(int playerID)
        {
            List<Card> playfield = playerID == 0 ? Globals.gameHandler.gameBoard.playingField1 : Globals.gameHandler.gameBoard.playingField2;
            Card c = new PyromaniaAdddiction(Vector2.Zero, true, playerID);
            c.OnEnter(playerID);
            playfield.Add(c);
            Globals.gameHandler.gameBoard.ResetPositionsField(playerID, playfield);
        }
    }
}
