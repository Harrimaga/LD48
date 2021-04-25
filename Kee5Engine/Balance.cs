using LD48.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48
{
    public static class Balance
    {
        public static int baseDrawCost = 10;
        public static int baseCollectableCost = 10;

        public static int GetDrawCost(int x)
        {
            return (int)Math.Floor(baseDrawCost * Math.Pow(x, 2));
        }

        public static bool IsAddiction(Category cat, int x)
        {
            return x >= 3;
        }
    }
}
