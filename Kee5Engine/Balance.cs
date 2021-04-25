using LD48.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48
{
    public static class Balance
    {
        public static int baseDrawCost = 10;
        public static int baseHousingCost = 150;
        public static int baseElectricityCost = 15;
        public static int baseInternetCost = 20;
        public static int baseTravelCost = 50;
        public static int baseCollectableCost = 10;
        public static int baseCollectableHappiness = 1;
        public static int maxTurns = 10;

        public static int GoToStartMoney = 200;

        public static int collectableCost = 5;

        public static int drugsCollectableIllegal = 1;
        public static int gamblingPayout = 10000;
        public static double gamblingChance = 0.0001;

        public static int alcoholHappiness = -5;
        public static int alcoholCosts = 100;

        public static int smokingHappiness = -5;
        public static int smokingCosts = 100;

        public static int drugsIllegal = 5;
        public static int drugsCosts = 200;

        public static int gamingElecticity = 2;
        public static int gamingInternet = 1;
        public static int gamingCosts = 30;

        public static int fastFoodTravel = 1;
        public static int fastFoodCosts = 50;

        public static int eatingOutTravel = 2;
        public static int eatingOutCosts = 100;

        public static int shoppingTravel = 2;
        public static int shoppingCosts = 100;

        public static int gamblingTravel = 1;
        public static int gamblingCosts = 250;

        public static int pomInternet = 2;
        public static int pomElecticity = 1;
        public static int pomCosts = 50;

        public static int streamingInternet = 3;
        public static int streamingElecticity = 3;
        public static int streamingCosts = 30;

        public static int socialMediaInternet = 3;
        public static int socialMediaCosts = 30;


        public static int GetDrawCost(int x)
        {
            return (int)Math.Floor(baseDrawCost * Math.Pow(x, 2));
        }

        public static int GetHousingCost(int x)
        {
            return (int)Math.Floor(baseHousingCost * Math.Pow(x, 2));
        }

        public static int GetElecticityCost(int x)
        {
            return (int)Math.Floor(baseElectricityCost * Math.Pow(x, 2));
        }

        public static int GetTravelCost(int x)
        {
            return (int)Math.Floor(baseTravelCost * Math.Pow(x, 2));
        }

        public static int GetInternetCost(int x)
        {
            return (int)Math.Floor(baseInternetCost * Math.Pow(x, 2));
        }

        public static bool IsAddiction(Category cat, int x)
        {
            return x >= 3;
        }
    }
}
