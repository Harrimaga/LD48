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
        protected List<Category> categories;
        public Collectable(string name, Vector2 position, bool front, int playerID) : base(name, position, front, playerID)
        {

        }
    }
}
