using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class PomXMLAddiction : Addiction
    {
        public PomXMLAddiction(Vector2 position, bool front, int playerID) : base("Pom.XML", position, front, playerID, Category.POM_XML)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(Balance.pomElecticity);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(Balance.pomInternet);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddElecticity(-Balance.pomElecticity);
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(-Balance.pomInternet);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.pomCosts);
            base.Activate();
        }

    }
}