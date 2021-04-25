using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic.Cards.Jobs
{
    public class DeliveryPerson : Income
    {

        public DeliveryPerson(Vector2 position, bool front, int playerID) : base("Delivery Person", position, front, playerID)
        {

        }

        public override int GetIncome()
        {
            return Balance.incomeLow;
        }
    }
}