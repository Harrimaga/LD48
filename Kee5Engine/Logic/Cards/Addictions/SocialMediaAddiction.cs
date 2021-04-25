using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Addictions
{
    public class SocialMediaAddiction : Addiction
    {
        public SocialMediaAddiction(Vector2 position, bool front, int playerID) : base("Social Media", position, front, playerID, Category.SOCIALMEDIA)
        {

        }

        public override void OnEnter(int playerID)
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(Balance.socialMediaInternet);
            base.OnEnter(playerID);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddInternet(-Balance.socialMediaInternet);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.socialMediaCosts);
            base.Activate();
        }

    }
}