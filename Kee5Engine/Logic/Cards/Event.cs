using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards
{
    public abstract class Event : Card
    {
        public Event(string name, Vector2 position, bool front, int playerID) : base(name, position, front, playerID, "EventCard")
        {
            _card.SetRotation(90);
        }

        public override void OnClick()
        {
            if (Globals.gameHandler.state == TurnState.PLAYER2)
            {
                return;
            }
            Globals.gameHandler.gameBoard.HandleEvent(this);
        }

        public override void Activate()
        {
            Globals.activeButtons.Remove(_card);
        }
    }
}
