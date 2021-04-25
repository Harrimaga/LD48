using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class DrugsAddiction : Addiction
    {
        public DrugsAddiction(Vector2 position, bool front, int playerID) : base("Drugs", position, front, playerID, Category.DRUGS)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(Balance.drugsIllegal);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddIllegal(-Balance.drugsIllegal);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.drugsCosts);
            base.Activate();
        }

    }
}
