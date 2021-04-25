using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class StreamingAddiction : Addiction
    {
        public StreamingAddiction(Vector2 position, bool front, int playerID) : base("Streaming", position, front, playerID, Category.STREAMING)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(Balance.streamingElecticity);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(Balance.streamingInternet);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(-Balance.streamingElecticity);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(-Balance.streamingInternet);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.streamingCosts);
            base.Activate();
        }

    }
}