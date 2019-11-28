﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR.Products;

namespace HallOfBeorn.Models.LotR
{
    public class Product : IProduct<Product, CardSet, LotRCard>
    {
        protected Product(string name, string code, ImageType imageType, DateTime firstReleased)
        {
            this.Name = name;
            this.Code = code;
            this.ImageType = imageType;
            this.FirstReleased = firstReleased;
        }

        private readonly List<CardSet> cardSets = new List<CardSet>();
        private readonly List<Scenario> scenarios = new List<Scenario>();

        protected void AddCardSet(CardSet cardSet)
        {
            cardSet.Product = this;
            cardSets.Add(cardSet);
        }

        protected void AddScenario(Scenario scenario)
        {
            if (!string.IsNullOrEmpty(RulesUrl))
            {
                scenario.RulesUrl = RulesUrl;
            }

            scenarios.Add(scenario);
        }

        public string Name { get; private set; }
        public string Abbreviation { get { return Code; } }
        public string Code { get; private set; }
        public ImageType ImageType { get; private set; }
        public bool IsPremier { get; protected set; }
        public bool IsNewSubGroup { get; protected set; }
        public string RulesUrl { get; protected set; }
        public string BuyLink { get; protected set; }
        public DateTime FirstReleased { get; protected set; }

        public IEnumerable<CardSet> CardSets
        {
            get { return cardSets; }
        }

        public IEnumerable<Scenario> Scenarios()
        {
            return scenarios;
        }

        #region Static Members
        //The Core Set and Shadows of Mirkwood Cycle
        public static Product CoreSet = new Products.Core.CoreSetProduct();
        
        public static Product TheHuntForGollum = new Products.AdventurePack.TheHuntForGollumProduct();
        public static Product ConflictAtTheCarrock = new Products.AdventurePack.ConflictAtTheCarrockProduct();
        public static Product AJourneyToRhosgobel = new Products.AdventurePack.AJourneyToRhosgobelProduct();
        public static Product TheHillsOfEmynMuil = new Products.AdventurePack.TheHillsOfEmynMuilProduct();
        public static Product TheDeadMarshes = new Products.AdventurePack.TheDeadMarshesProduct();
        public static Product ReturnToMirkwood = new Products.AdventurePack.ReturnToMirkwoodProduct();
        
        //Khzad-dum and Dwarrowdelf Cycle
        public static Product KhazadDum = new Products.Deluxe.KhazadDumProduct();

        public static Product TheRedhornGate = new Products.AdventurePack.TheRedhornGateProduct();
        public static Product RoadToRivendell = new Products.AdventurePack.RoadToRivendellProduct();
        public static Product TheWatcherInTheWater = new Products.AdventurePack.TheWatcherInTheWaterProduct();
        public static Product TheLongDark = new Products.AdventurePack.TheLongDarkProduct();
        public static Product FoundationsOfStone = new Products.AdventurePack.FoundationsOfStoneProduct();
        public static Product ShadowAndFlame = new Products.AdventurePack.ShadowAndFlameProduct();

        //Heirs of Numenor and Against the Shadow Cycle
        public static Product HeirsOfNumenor = new Products.Deluxe.HeirsOfNumenorProduct();

        public static Product TheStewardsFear = new Products.AdventurePack.TheStewardsFearProduct();
        public static Product TheDruadanForest = new Products.AdventurePack.TheDruadanForestProduct();
        public static Product EncounterAtAmonDin = new Products.AdventurePack.EncounterAtAmonDinProduct();
        public static Product AssaultOnOsgiliath = new Products.AdventurePack.AssaultOnOsgiliathProduct();
        public static Product TheBloodOfGondor = new Products.AdventurePack.TheBloodOfGondorProduct();
        public static Product TheMorgulVale = new Products.AdventurePack.TheMorgulValeProduct();

        //The Voice of Isengard and The Ring-maker Cycle
        public static Product TheVoiceOfIsengard = new Products.Deluxe.TheVoiceOfIsengardProduct();

        public static Product TheDunlandTrap = new Products.AdventurePack.TheDunlandTrapProduct();
        public static Product TheThreeTrials = new Products.AdventurePack.TheThreeTrialsProduct();
        public static Product TroubleInTharbad = new Products.AdventurePack.TroubleInTharbadProduct();
        public static Product TheNinInEilph = new Products.AdventurePack.TheNinInEilphProduct();
        public static Product CelebrimborsSecret = new Products.AdventurePack.CelebrimborsSecretProduct();
        public static Product TheAntleredCrown = new Products.AdventurePack.TheAntleredCrownProduct();

        //The Lost Realm and Angmar Awakened Cycle
        public static Product TheLostRealm = new Products.Deluxe.TheLostRealmProduct();
        public static Product TheWastesOfEriador = new Products.AdventurePack.TheWastesOfEriadorProduct();
        public static Product EscapeFromMountGram = new Products.AdventurePack.EscapeFromMountGramProduct();
        public static Product AcrossTheEttenmoors = new Products.AdventurePack.AcrossTheEttenmoorsProduct();
        public static Product TheTreacheryOfRhudaur = new Products.AdventurePack.TheTreacheryOfRhudaurProduct();
        public static Product TheBattleOfCarnDum = new Products.AdventurePack.TheBattleOfCarnDumProduct();
        public static Product TheDreadRealm = new Products.AdventurePack.TheDreadRealmProduct();

        //The Grey Havens and Dream-chaser Cycle
        public static Product TheGreyHavens = new Products.Deluxe.TheGreyHavensProduct();
        public static Product FlightOfTheStormcaller = new Products.AdventurePack.FlightOfTheStormcallerProduct();
        public static Product TheThingInTheDepths = new Products.AdventurePack.TheThingInTheDepthsProduct();
        public static Product TempleOfTheDeceived = new Products.AdventurePack.TempleOfTheDeceivedProduct();
        public static Product TheDrownedRuins = new Products.AdventurePack.TheDrownedRuinsProduct();
        public static Product AStormOnCobasHaven = new Products.AdventurePack.AStormOnCobasHavenProduct();
        public static Product TheCityOfCorsairs = new Products.AdventurePack.TheCityOfCorsairsProduct();

        //The Sands of Harad and Haradrim Cycle
        public static Product TheSandsOfHarad = new Products.Deluxe.TheSandsOfHaradProduct();
        public static Product TheMumakil = new Products.AdventurePack.TheMumakilProduct();
        public static Product RaceAcrossHarad = new Products.AdventurePack.RaceAcrossHaradProduct();
        public static Product BeneathTheSands = new Products.AdventurePack.BeneathTheSandsProduct();
        public static Product TheBlackSerpent = new Products.AdventurePack.TheBlackSerpentProduct();
        public static Product TheDungeonsOfCirithGurat = new Products.AdventurePack.TheDungeonsOfCirithGuratProduct();
        public static Product TheCrossingsOfPoros = new Products.AdventurePack.TheCrossingsOfPorosProduct();

        //The Wilds of Rhovanion and Ered Mithin Cycle
        public static Product TheWildsOfRhovanion = new Products.Deluxe.TheWildsOfRhovanionProduct();
        public static Product TheWitheredHeath = new Products.AdventurePack.TheWitheredHeathProduct();
        public static Product RoamAcrossRhovanion = new Products.AdventurePack.RoamAcrossRhovanionProduct();
        public static Product FireInTheNight = new Products.AdventurePack.FireInTheNightProduct();
        public static Product TheGhostOfFramsburg = new Products.AdventurePack.TheGhostOfFramsburgProduct();
        public static Product MountGundabad = new Products.AdventurePack.MountGundabadProduct();
        public static Product TheFateOfWilderland = new Products.AdventurePack.TheFateOfWilderlandProduct();

        //A Shadow in the East and Vengeance of Mordor Cycle
        public static Product AShadowInTheEast = new Products.Deluxe.AShadowInTheEastProduct();
        public static Product WrathAndRuin = new Products.AdventurePack.WrathAndRuinProduct();
        public static Product TheCityOfUlfast = new Products.AdventurePack.TheCityOfUlfastProduct();
        public static Product TheWainridersChallenge = new Products.AdventurePack.ChallengeOfTheWainridersProduct();

        //The Hobbit Saga
        public static Product TheHobbitOverHillAndUnderHill = new Products.Saga.TheHobbitOverHillAndUnderHillProduct();
        public static Product TheHobbitOnTheDoorstep = new Products.Saga.TheHobbitOnTheDoorstepProduct();

        //The Lord of the Rings Saga
        public static Product TheBlackRiders = new Products.Saga.TheBlackRidersProduct();
        public static Product TheRoadDarkens = new Products.Saga.TheRoadDarkensProduct();
        public static Product TheTreasonOfSaruman = new Products.Saga.TheTreasonOfSarumanProduct();
        public static Product TheLandOfShadow = new Products.Saga.TheLandOfShadowProduct();
        public static Product TheFlameOfTheWest = new Products.Saga.TheFlameOfTheWestProduct();
        public static Product TheMountainOfFire = new Products.Saga.TheMountainOfFireProduct();

        //Starter
        public static Product TwoPlayerLimitedEditionStarter = new Products.Starter.TwoPlayerLimitedEditionStarterProduct();

        //GenCon and Fellowship Event Decks
        public static Product TheMassingAtOsgiliath = new Products.PrintOnDemand.TheMassingAtOsgiliathProduct();
        public static Product TheBattleOfLakeTown = new Products.PrintOnDemand.TheBattleOfLakeTownProduct();
        public static Product TheStoneOfErech = new Products.PrintOnDemand.TheStoneOfErechProduct();
        public static Product TheOldForest = new Products.PrintOnDemand.TheOldForestProduct();
        public static Product FogOnTheBarrowDowns = new Products.PrintOnDemand.FogOnTheBarrowDownsProduct();
        public static Product TheRuinsOfBelegost = new Products.PrintOnDemand.TheRuinsOfBelegostProduct();
        public static Product MurderAtThePrancingPony = new Products.PrintOnDemand.MurderAtThePrancingPonyProduct();
        public static Product TheSiegeOfAnnuminas = new Products.PrintOnDemand.TheSiegeOfAnnuminasProduct();
        public static Product AssaultOnDolGuldur = new Products.PrintOnDemand.AttackOnDolGuldurProduct();
        public static Product TheWizardsQuest = new Products.PrintOnDemand.TheWizardsQuestProduct();
        public static Product TheWoodlandRealm = new Products.PrintOnDemand.TheWoodlandRealmProduct();

        //Nightmare Decks
        public static Product PassageThroughMirkwoodNightmare = new Products.Nightmare.PassageThroughMirkwoodNightmareProduct();
        public static Product JourneyAlongTheAnduinNightmare = new Products.Nightmare.JourneyAlongTheAnduinNightmareProduct();
        public static Product EscapeFromDolGuldurNightmare = new Products.Nightmare.EscapeFromDolGuldurNightmareProduct();

        public static Product TheHuntForGollumNightmare = new Products.Nightmare.TheHuntForGollumNightmareProduct();
        public static Product ConflictAtTheCarrockNightmare = new Products.Nightmare.ConflictAtTheCarrockNightmareProduct();
        public static Product AJourneyToRhosgobelNightmare = new Products.Nightmare.AJourneyToRhosgobelNightmareProduct();
        public static Product TheHillsOfEmynMuilNightmare = new Products.Nightmare.TheHillsOfEmynMuilNightmareProduct();
        public static Product TheDeadMarshesNightmare = new Products.Nightmare.TheDeadMarshesNightmareProduct();
        public static Product ReturnToMirkwoodNightmare = new Products.Nightmare.ReturnToMirkwoodNightmareProduct();

        public static Product KhazadDumNightmare = new Products.Nightmare.KhazadDumNightmareProduct();

        public static Product TheRedhornGateNightmare = new Products.Nightmare.TheRedhornGateNightmareProduct();
        public static Product RoadToRivendellNightmare = new Products.Nightmare.RoadToRivendellNightmareProduct();
        public static Product TheWatcherInTheWaterNightmare = new Products.Nightmare.TheWatcherInTheWaterNightmareProduct();
        public static Product TheLongDarkNightmare = new Products.Nightmare.TheLongDarkNightmareProduct();
        public static Product FoundationsOfStoneNightmare = new Products.Nightmare.FoundationsOfStoneNightmareProduct();
        public static Product ShadowAndFlameNightmare = new Products.Nightmare.ShadowAndFlameNightmareProduct();

        public static Product HeirsOfNumenorNightmare = new Products.Nightmare.HeirsOfNumenorNightmareProduct();

        public static Product TheStewardsFearNightmare = new Products.Nightmare.TheStewardsFearNightmareProduct();
        public static Product TheDruadanForestNightmare = new Products.Nightmare.TheDruadanForestNightmareProduct();
        public static Product EncounterAtAmonDinNightmare = new Products.Nightmare.EncounterAtAmonDinNightmareProduct();
        public static Product AssaultOnOsgiliathNightmare = new Products.Nightmare.AssaultOnOsgiliathNightmareProduct();
        public static Product TheBloodOfGondorNightmare = new Products.Nightmare.TheBloodOfGondorNightmareProduct();
        public static Product TheMorgulValeNightmare = new Products.Nightmare.TheMorgulValeNightmareProduct();

        public static Product TheVoiceOfIsengardNightmare = new Products.Nightmare.TheVoiceOfIsengardNightmareProduct();
        public static Product TheDunlandTrapNightmare = new Products.Nightmare.TheDunlandTrapNightmareProduct();
        public static Product TheThreeTrialsNightmare = new Products.Nightmare.TheThreeTrialsNightmareProduct();
        public static Product TroubleInTharbadNightmare = new Products.Nightmare.TroubleInTharbadNightmareProduct();
        public static Product TheNinInEilphNightmare = new Products.Nightmare.TheNinInEilphNightmareProduct();
        public static Product CelebrimborsSecretNightmare = new Products.Nightmare.CelebrimborsSecretNightmareProoduct();
        public static Product TheAntleredCrownNightmare = new Products.Nightmare.TheAntleredCrownNightmareProduct();

        public static Product TheLostRealmNightmare = new Products.Nightmare.TheLostRealmNightmareProduct();
        public static Product TheWastesOfEriadorNightmare = new Products.Nightmare.TheWastesOfEriadorNightmareProduct();
        public static Product EscapeFromMountGramNightmare = new Products.Nightmare.EscapeFromMountGramNightmareProduct();
        public static Product AcrossTheEttenmoorsNightmare = new Products.Nightmare.AcrossTheEttenmoorsNightmareProduct();
        public static Product TheTreacheryOfRhudaurNightmare = new Products.Nightmare.TheTreacheryOfRhudaurNightmareProduct();
        public static Product TheBattleOfCarnDumNightmare = new Products.Nightmare.TheBattleOfCarnDumNightmareProduct();
        public static Product TheDreadRealmNightmare = new Products.Nightmare.TheDreadRealmNightmareProduct();

        public static Product TheGreyHavensNightmare = new Products.Nightmare.TheGreyHavensNightmareProduct();
        public static Product FlightOfTheStormcallerNightmare = new Products.Nightmare.FlightOfTheStormcallerNightmareProduct();
        public static Product TheThingInTheDepthsNightmare = new Products.Nightmare.TheThingInTheDepthsNightmareProduct();
        public static Product TempleOfTheDeceivedNightmare = new Products.Nightmare.TempleOfTheDeceivedNightmareProduct();
        public static Product TheDrownedRuinsNightmare = new Products.Nightmare.TheDrownedRuinsNightmareProduct();
        public static Product AStormOnCobasHavenNightmare = new Products.Nightmare.AStormOnCobasHavenNightmareProduct();
        public static Product TheCityOfCorsairsNightmare = new Products.Nightmare.TheCityOfCorsairsNightmareProduct();

        public static Product TheHobbitOverHillAndUnderHillNightmare = new Products.Nightmare.TheHobbitOverHillAndUnderHillNightmareProduct();
        public static Product TheHobbitOnTheDoorstepNightmare = new Products.Nightmare.TheHobbitOnTheDoorstepNightmareProduct();

        public static Product TheBlackRidersNightmare = new Products.Nightmare.TheBlackRidersNightmareProduct();
        public static Product TheRoadDarkensNightmare = new Products.Nightmare.TheRoadDarkensNightmareProduct();
        public static Product TheTreasonOfSarumanNightmare = new Products.Nightmare.TheTreasonOfSarumanNightmareProduct();
        public static Product TheLandOfShadowNightmare = new Products.Nightmare.TheLandOfShadowNightmareProduct();

        //Custom Expansions
        public static Product FirstAge = new Products.Custom.FirstAgeProduct();
        public static Product TrialUponTheMarches = new Products.Custom.TrialUponTheMarchesProduct();
        public static Product AmongTheOutlaws = new Products.Custom.AmongTheOutlawsProduct();

        #endregion
    }
}