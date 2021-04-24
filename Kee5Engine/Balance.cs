using System;
using System.Collections.Generic;
using System.Text;

namespace LD48
{
    public static class Balance
    {
        public static int baseDrawCost = 10;

        public static int GetDrawCost(int x)
        {
            return (int)Math.Floor(baseDrawCost * Math.Pow(x, 2));
        }
    }
}
