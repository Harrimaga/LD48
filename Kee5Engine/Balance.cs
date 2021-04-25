using LD48.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD48
{
    public static class Balance
    {
        public static int baseDrawCost = 10;
        public static int baseHousingCost = 50;
        public static int baseElectricityCost = 5;
        public static int baseInternetCost = 5;
        public static int baseTravelCost = 10;
        public static int baseCollectableCost = 10;
        public static int baseCollectableHappiness = 1;
        public static int baseIllegalCost = 50;
        public static int maxTurns = 10;
        public static double happinessIncomeMod = 0.1;

        public static int collectableCost = 5;

        public static int drugsCollectableIllegal = 1;
        public static int gamblingPayout = 10000;
        public static double gamblingChance = 0.0001;

        // Addictions
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

        public static int kleptomaniaIllegal = 2;
        public static int pyromaniaIllegal = 2;

        // Income
        public static int incomeLow = 50;
        public static int incomeMhe = 100;
        public static int incomeHigh = 200;

        public static int drugDealerIllegal = 2;
        public static int onlyFansInternet = 1;
        public static int instaModelTravel = 2;
        public static int streamerInternet = 1;
        public static int artistHappiness = 5;
        public static int actorTravel = 1;
        public static int internDevElectricity = 1;
        public static int juniorDevElectricity = 1;
        public static int indieGameDevElectricity = 1;
        public static int influencerInternet = 1;
        public static int influencerTravel = 1;
        public static int astrophysicistHousing = 1;
        public static int astrophysicistTravel = 1;
        public static int musicianHappiness = 5;
        public static int musicianElectricity = 1;
        public static int writerElectricity = 1;
        public static int startupTravel = 1;
        public static int refereeTravel = 1;
        public static int refereeHappiness = -1;
        public static int taxiDriverTravel = 2;
        public static int sporterHousing = 1;
        public static int sporterTravel = 1;
        public static int yogaHousing = 1;
        public static int fastFoodEmployeeHappiness = -1;
        public static int babysitterHappiness = -1;
        public static int babysitterUIllegal = 1;
        public static int hitmanIllegal = 3;
        public static int hitmanTravel = 1;
        public static int shoplifterIllegal = 1;
        public static int conmanIllegal = 1;
        public static int hackerIllegal = 2;
        public static int hackerInternet = 1;
        public static int hackerElectricity = 1;
        public static int humanTraffickerIllegal = 3;
        public static int humanTraffickerTravel = 2;
        public static int sugarDaddyInternet = 1;

        // Events
        public static int GoToStartMoney = 200;
        public static int StonksMoney = 500;
        public static double EventGamblingChance = 0.1;
        public static int EventGamblingLoss = 50;
        public static int EventGamblingWin = -1000;
        public static int ConcertCost = 100;
        public static int ConcertHappiness = 2;
        public static int PartyCost = 50;
        public static double PartyChance = 0.2;
        public static int CinemaCost = 50;
        public static int CinemaHappiness = 1;
        public static double ShankedChance = 0.5;
        public static int ShankedAmount = -500;
        public static double CarChance = 0.2;
        public static int CarAmount = -300;
        public static int BankErrorAmount = -200;
        public static int TaxAmount = 500;
        public static int BirtdayAmount = 50;
        public static int HolidayCost = 150;
        public static int HolidayTravel = 1;
        public static int HolidayHappiness = 2;

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

        public static int GetPopoCost(int x)
        {
            return (int)Math.Floor(baseIllegalCost * Math.Pow(x, 2));
        }

        public static bool IsAddiction(Category cat, int x)
        {
            return x >= 3;
        }

        public static int ModifyIncome(int income, int happiness)
        {
            return (int)(income * (happiness * happinessIncomeMod + 1));
        }

    }
}
