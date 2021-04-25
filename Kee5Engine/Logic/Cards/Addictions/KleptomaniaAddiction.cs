using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class KleptomaniaAdddiction : Addiction
    {
        public KleptomaniaAdddiction(Vector2 position, bool front, int playerID) : base("Kleptomania", position, front, playerID, Category.ALCOHOL)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(Balance.kleptomaniaIllegal);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(-Balance.kleptomaniaIllegal);
            base.OnLeave();
        }

    }
}
