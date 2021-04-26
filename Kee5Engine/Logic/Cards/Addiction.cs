using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards
{
    public abstract class Addiction : Card
    {
        protected Category category;

        public Addiction(string name, Vector2 position, bool front, int playerID, Category category) : base(name, position, front, playerID, name)
        {
            this.category = category;
        }

        public Category GetCategory()
        {
            return category;
        }

    }
}
