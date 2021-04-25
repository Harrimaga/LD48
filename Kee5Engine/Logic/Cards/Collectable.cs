using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards
{
    public enum Category
    {
        ALCOHOL,
        SMOKING,
        DRUGS,
        GAMING,
        FASTFOOD,
        EATINGOUT,
        SHOPPING,
        GAMBLING,
        POM_XML,
        STREAMING,
        SOCIALMEDIA
    }

    public abstract class Collectable : Card
    {
        protected List<Category> categories = new List<Category>();
        public Collectable(string name, Vector2 position, bool front, int playerID) : base(name, position, front, playerID)
        {

        }

        public void StartSelection()
        {
            Globals.cardSelected = this;
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

        public override void OnEnter(int playerID)
        {
            this.playerID = playerID;
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(Balance.baseCollectableHappiness);
        }

        public override void OnLeave()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddHappiness(-Balance.baseCollectableHappiness);
            base.OnLeave();
        }

        public override void Activate()
        {
            Globals.gameHandler.GetPlayerFromID(playerID).AddDebt(Balance.baseCollectableCost);
        }
    }
}
