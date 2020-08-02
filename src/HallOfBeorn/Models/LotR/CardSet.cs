﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public abstract class CardSet : ICardSet<Product, LotRCard>
    {
        protected CardSet()
        {
            Cards = new List<LotRCard>();

            Initialize();

            foreach (var card in Cards)
            {
                card.CardSet = this;
            }
        }

        private string normalizedName;

        protected abstract void Initialize();

        protected void addCard(LotRCard card)
        {
            this.Cards.Add(card);
        }

        protected LotRCard addHero(string title, byte threatCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var hero = LotRCard.Hero(title, string.Empty, sphere, threatCost, willpower, attack, defense, hitPoints);
            addCard(hero);
            return hero;
        }

        protected LotRCard addAlly(string title, byte resourceCost, Sphere sphere, bool isUnique, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var card = LotRCard.Ally(title, sphere, resourceCost, willpower, attack, defense, hitPoints);
            card.IsUnique = isUnique;
            addCard(card);
            return card;
        }

        protected LotRCard addAttachment(string title, byte resourceCost, Sphere sphere, bool isUnique)
        {
            var attachment = LotRCard.Attachment(title, string.Empty, sphere, resourceCost);
            attachment.IsUnique = isUnique;
            addCard(attachment);
            return attachment;
        }

        protected LotRCard addEvent(string title, byte resourceCost, Sphere sphere)
        {
            var card = LotRCard.Event(title, string.Empty, sphere, resourceCost);
            addCard(card);
            return card;
        }

        protected LotRCard addPlayerSideQuest(string title, byte resourceCost, Sphere sphere, byte questPoints)
        {
            var sideQuest = LotRCard.PlayerSideQuest(title, string.Empty, sphere, resourceCost, questPoints);
            addCard(sideQuest);
            return sideQuest;
        }

        protected LotRCard addContract(string title)
        {
            var card = LotRCard.Contract(title);
            addCard(card);
            return card;
        }

        protected LotRCard addGenConSetup(string title, string encounterSet)
        {
            var setup = LotRCard.GenConSetup(title, encounterSet);
            addCard(setup);
            return setup;
        }

        protected LotRCard addGenConSetup(string title, EncounterSet encounterSet)
        {
            return addGenConSetup(title, encounterSet.Name);
        }

        protected LotRCard addNightmareSetup(string encounterSet)
        {
            var card = LotRCard.NightmareSetup(encounterSet, encounterSet);
            addCard(card);
            return card;
        }

        protected LotRCard addNightmareSetup(EncounterSet encounterSet)
        {
            return addNightmareSetup(encounterSet.Name);
        }

        protected LotRCard addQuest(string title, string encounterSet, uint stageNumber, char stageLetter, byte? questPoints)
        {
            var quest = LotRCard.Quest(title, stageNumber, encounterSet, questPoints, stageLetter);
            addCard(quest);
            return quest;
        }

        protected LotRCard addQuest(string title, EncounterSet encounterSet, uint stageNumber, char stageLetter, byte? questPoints)
        {
            return addQuest(title, encounterSet.Name, stageNumber, stageLetter, questPoints);
        }

        protected LotRCard addEnemy(string title, string encounterSet, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            var enemy = LotRCard.Enemy(title, string.Empty, encounterSet, engagementCost, threat, attack, defense, hitPoints);
            addCard(enemy);
            return enemy;
        }

        protected LotRCard addEnemy(string title, EncounterSet encounterSet, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            return addEnemy(title, encounterSet.Name, engagementCost, threat, attack, defense, hitPoints);
        }

        protected LotRCard addShipEnemy(string title, string encounterSet, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            var shipEnemy = LotRCard.ShipEnemy(title, encounterSet, engagementCost, threat, attack, defense, hitPoints);
            addCard(shipEnemy);
            return shipEnemy;
        }

        protected LotRCard addShipEnemy(string title, EncounterSet encounterSet, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            return addShipEnemy(title, encounterSet.Name, engagementCost, threat, attack, defense, hitPoints);
        }

        protected LotRCard addLocation(string title, string encounterSet, byte? threat, byte? questPoints)
        {
            var location = LotRCard.Location(title, string.Empty, encounterSet, threat, questPoints);
            addCard(location);
            return location;
        }

        protected LotRCard addLocation(string title, EncounterSet encounterSet, byte? threat, byte? questPoints)
        {
            return addLocation(title, encounterSet.Name, threat, questPoints);
        }

        protected LotRCard addTreachery(string title, string encounterSet)
        {
            var treachery = LotRCard.Treachery(title, string.Empty, encounterSet);
            addCard(treachery);
            return treachery;
        }

        protected LotRCard addTreachery(string title, EncounterSet encounterSet)
        {
            return addTreachery(title, encounterSet.Name);
        }

        protected LotRCard addEncounterSideQuest(string title, string encounterSet, byte? questPoints)
        {
            var sideQuest = LotRCard.EncounterSideQuest(title, string.Empty, encounterSet, questPoints);
            addCard(sideQuest);
            return sideQuest;
        }

        protected LotRCard addEncounterSideQuest(string title, EncounterSet encounterSet, byte? questPoints)
        {
            return addEncounterSideQuest(title, encounterSet.Name, questPoints);
        }

        protected LotRCard addObjective(string title, string encounterSet)
        {
            var objective = LotRCard.Objective(title, string.Empty, encounterSet);
            addCard(objective);
            return objective;
        }

        protected LotRCard addObjective(string title, EncounterSet encounterSet)
        {
            return addObjective(title, encounterSet.Name);
        }

        protected LotRCard addObjectiveAlly(string title, string encounterSet, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var objectiveAlly = LotRCard.ObjectiveAlly(title, string.Empty, encounterSet, willpower, attack, defense, hitPoints);
            addCard(objectiveAlly);
            return objectiveAlly;
        }

        protected LotRCard addObjectiveAlly(string title, EncounterSet encounterSet, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return addObjectiveAlly(title, encounterSet.Name, willpower, attack, defense, hitPoints);
        }

        protected LotRCard addObjectiveLocation(string title, string encounterSet, byte questPoints, bool isUnique, byte? victoryPoints)
        {
            var objectiveLocation = LotRCard.ObjectiveLocation(title, encounterSet, questPoints);
            objectiveLocation.IsUnique = isUnique;
            if (victoryPoints.HasValue)
            {
                objectiveLocation.VictoryPoints = victoryPoints.Value;
            }
            addCard(objectiveLocation);
            return objectiveLocation;
        }

        protected LotRCard addObjectiveLocation(string title, EncounterSet encounterSet, byte questPoints, bool isUnique, byte? victoryPoints)
        {
            return addObjectiveLocation(title, encounterSet.Name, questPoints, isUnique, victoryPoints);
        }

        protected LotRCard addObjectiveHero(string title, string encounterSet, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var objectiveHero = LotRCard.ObjectiveHero(title, encounterSet, willpower, attack, defense, hitPoints);
            objectiveHero.IsUnique = true;
            addCard(objectiveHero);
            return objectiveHero;
        }

        protected LotRCard addObjectiveHero(string title, EncounterSet encounterSet, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return addObjectiveHero(title, encounterSet.Name, willpower, attack, defense, hitPoints);
        }

        protected LotRCard addShipObjective(string title, string encounterSet, bool isUnique, byte? willpower, byte? attack, byte? defense, byte? hitPoints)
        {
            var shipObjective = LotRCard.ShipObjective(title, encounterSet, willpower, attack, defense, hitPoints);
            shipObjective.IsUnique = isUnique;
            addCard(shipObjective);
            return shipObjective;
        }

        protected LotRCard addShipObjective(string title, EncounterSet encounterSet, bool isUnique, byte? willpower, byte? attack, byte? defense, byte? hitPoints)
        {
            return addShipObjective(title, encounterSet.Name, isUnique, willpower, attack, defense, hitPoints);
        }

        protected LotRCard addCampaign(string title, string encounterSet, string oppositeTitle)
        {
            var campaign = LotRCard.Campaign(title, encounterSet, oppositeTitle);
            addCard(campaign);
            return campaign;
        }

        protected LotRCard addCampaign(string title, EncounterSet encounterSet, string oppositeTitle)
        {
            return addCampaign(title, encounterSet.Name, oppositeTitle);
        }

        public string Id { get; protected set; }

        private string name;
        public string Name 
        {
            get { return name; }
            protected set {
                name = value;
                var norm = name.NormalizeCaseSensitiveString();
                if (norm != name) {
                    normalizedName = norm;
                }
            }
        }
        
        public string NormalizedName
        {
            get
            {
                return (!string.IsNullOrEmpty(normalizedName)) ?
                    normalizedName
                    : Name;
            }
        }

        public string Abbreviation { get; protected set; }

        private string publicSlug;
        public string PublicSlug
        {
            get { return !string.IsNullOrEmpty(publicSlug) ? publicSlug : Abbreviation.ToLower(); }
            protected set { publicSlug = value; }
        }

        public string Slug { get { return PublicSlug; } }

        public string LookupSlug { get { return NormalizedName.ToSlug(); } }

        public string Cycle { get; protected set; }
        public int Number { get; protected set; }
        public SetType SetType { get; protected set; }
        public List<LotRCard> Cards { get; protected set; }
        public Product Product { get; set; }

        private readonly List<EncounterSet> encounterSets = new List<EncounterSet>();
        protected void addEncounterSets(params EncounterSet[] sets)
        {
            foreach (var encounterSet in sets) {

                foreach (var card in encounterSet.Cards()) {
                    if (card.CardSet == null) {
                        card.CardSet = this;
                    }
                }

                this.encounterSets.Add(encounterSet);
            }
        }
        public IEnumerable<EncounterSet> EncounterSets()
        {
            return encounterSets;
        }

        public string AlternateName { get; protected set; }

        public bool IsNightmare { get { return !string.IsNullOrEmpty(Name) && Name.EndsWith(" Nightmare"); } }

        public bool IsSpoiler { get; protected set; }

        private static List<CardSet> all = new List<CardSet>();

        private static void Add(CardSet cardSet)
        {
            all.Add(cardSet);
        }

        static CardSet()
        {
            Add(CoreSet);
            Add(TheHuntForGollum);
            Add(ConflictAtTheCarrock);
            Add(AJourneyToRhosgobel);
            Add(TheHillsOfEmynMuil);
            Add(TheDeadMarshes);
            Add(ReturnToMirkwood);
        
            Add(KhazadDum);
            Add(TheRedhornGate);
            Add(RoadToRivendell);
            Add(TheWatcherInTheWater);
            Add(TheLongDark);
            Add(FoundationsOfStone);
            Add(ShadowAndFlame);

            Add(HeirsOfNumenor);
            Add(TheStewardsFear);
            Add(TheDruadanForest);
            Add(EncounterAtAmonDin);
            Add(AssaultOnOsgiliath);
            Add(TheBloodOfGondor);
            Add(TheMorgulVale);

            Add(TheVoiceOfIsengard);
            Add(TheDunlandTrap);
            Add(TheThreeTrials);
            Add(TroubleInTharbad);
            Add(TheNinInEilph);
            Add(CelebrimborsSecret);
            Add(TheAntleredCrown);

            Add(TheLostRealm);
            Add(TheWastesOfEriador);
            Add(EscapeFromMountGram);
            Add(AcrossTheEttenmoors);
            Add(TheTreacheryOfRhudaur);
            Add(TheBattleOfCarnDum);
            Add(TheDreadRealm);

            Add(TheGreyHavens);
            Add(FlightOfTheStormcaller);
            Add(TheThingInTheDepths);
            Add(TempleOfTheDeceived);
            Add(TheDrownedRuins);
            Add(AStormOnCobasHaven);
            Add(TheCityOfCorsairs);

            Add(TheSandsOfHarad);
            Add(TheMumakil);
            Add(RaceAcrossHarad);
            Add(BeneathTheSands);
            Add(TheBlackSerpent);
            Add(TheDungeonsOfCirithGurat);
            Add(TheCrossingsOfPoros);

            Add(TheWildsOfRhovanion);
            Add(TheWitheredHeath);
            Add(RoamAcrossRhovanion);
            Add(FireInTheNight);
            Add(TheGhostOfFramsburg);
            Add(MountGundabad);
            Add(TheFateOfWilderland);

            Add(AShadowInTheEast);
            Add(WrathAndRuin);
            Add(TheCityOfUlfast);
            Add(ChallengeOfTheWainriders);
            Add(UnderTheAshMountains);
            Add(TheLandOfSorrow);
            Add(TheFortressOfNurn);

            Add(WrathAndRuinPreorderPromotion);
            Add(TheCityOfUlfastPreorderPromotion);
            Add(ChallengeOfTheWainridersPreorderPromotion);
            Add(UnderTheAshMountainsPreorderPromotion);

            Add(TheHobbitOverHillAndUnderHill);
            Add(TheHobbitOnTheDoorstep);

            Add(TheBlackRiders);
            Add(TheRoadDarkens);
            Add(TheTreasonOfSaruman);
            Add(TheLandOfShadow);
            Add(TheFlameOfTheWest);
            Add(TheMountainOfFire);

            Add(TwoPlayerLimitedEditionStarter);

            Add(TheMassingAtOsgiliath);
            Add(TheBattleOfLakeTown);
            Add(TheStoneOfErech);
            Add(TheRuinsOfBelegost);

            Add(TheOldForest);
            Add(FogOnTheBarrowDowns);
            Add(MurderAtThePrancingPony);
            Add(TheSiegeOfAnnuminas);
            Add(AttackOnDolGuldur);
            Add(TheWizardsQuest);
            Add(TheWoodlandRealm);
            Add(EscapeFromKhazadDum);
            Add(EscapeFromKhazadDumPreorderPromotion);

            Add(PassageThroughMirkwoodNightmare);
            Add(JourneyAlongTheAnduinNightmare);
            Add(EscapeFromDolGuldurNightmare);
            Add(TheHuntForGollumNightmare);
            Add(ConflictAtTheCarrockNightmare);
            Add(AJourneyToRhosgobelNightmare);
            Add(TheHillsOfEmynMuilNightmare);
            Add(TheDeadMarshesNightmare);
            Add(ReturnToMirkwoodNightmare);
            Add(IntoThePitNightmare);
            Add(TheSeventhLevelNightmare);
            Add(FlightFromMoriaNightmare);
            Add(TheRedhornGateNightmare);
            Add(RoadToRivendellNightmare);
            Add(TheWatcherInTheWaterNightmare);
            Add(TheLongDarkNightmare);
            Add(FoundationsOfStoneNightmare);
            Add(ShadowAndFlameNightmare);
            Add(PerilInPelargirNightmare);
            Add(IntoIthilienNightmare);
            Add(TheSiegeOfCairAndrosNightmare);
            Add(TheStewardsFearNightmare);
            Add(TheDruadanForestNightmare);
            Add(EncounterAtAmonDinNightmare);
            Add(AssaultOnOsgiliathNightmare);
            Add(TheBloodOfGondorNightmare);
            Add(TheMorgulValeNightmare);
            Add(TheFordsOfIsenNightmare);
            Add(ToCatchAnOrcNightmare);
            Add(IntoFangornNightmare);
            Add(TheDunlandTrapNightmare);
            Add(TheThreeTrialsNightmare);
            Add(TroubleInTharbadNightmare);
            Add(TheNinInEilphNightmare);
            Add(CelebrimborsSecretNightmare);
            Add(TheAntleredCrownNightmare);

            Add(IntrudersInChetwoodNightmare);
            Add(TheWeatherHillsNightmare);
            Add(DeadmensDikeNightmare);

            Add(TheWastesOfEriadorNightmare);
            Add(EscapeFromMountGramNightmare);
            Add(AcrossTheEttenmoorsNightmare);
            Add(TheTreacheryOfRhudaurNightmare);
            Add(TheBattleOfCarnDumNightmare);
            Add(TheDreadRealmNightmare);

            Add(VoyageAcrossBelegaerNightmare);
            Add(TheFateOfNumenorNightmare);
            Add(RaidOnTheGreyHavensNightmare);

            Add(FlightOfTheStormcallerNightmare);
            Add(TheThingInTheDepthsNightmare);
            Add(TempleOfTheDeceivedNightmare);
            Add(TheDrownedRuinsNightmare);
            Add(AStormOnCobasHavenNightmare);
            Add(TheCityOfCorsairsNightmare);

            Add(WeMustAwayEreBreakOfDayNightmare);
            Add(OverTheMistyMountainsGrimNightmare);
            Add(DungeonsDeepAndCavernsDimNightmare);
            
            Add(FliesAndSpidersNightmare);
            Add(TheLonelyMountainNightmare);
            Add(TheBattleOfFiveArmiesNightmare);

            Add(AShadowOfThePastNightmare);
            Add(AKnifeInTheDarkNightmare);
            Add(FlightToTheFordNightmare);

            Add(TheRingGoesSouthNightmare);
            Add(JourneyInTheDarkNightmare);
            Add(BreakingOfTheFellowshipNightmare);

            Add(TheUrukHaiNightmare);
            Add(HelmsDeepNightmare);
            Add(TheRoadToIsengardNightmare);

            Add(ThePassageOfTheMarshesNightmare);
            Add(JourneyToTheCrossRoadsNightmare);
            Add(ShelobsLairNightmare);

            Add(FirstAge);
            Add(TrialUponTheMarches);
            Add(AmongTheOutlaws);
        }

        public static List<CardSet> All()
        {
            return all;
        }

        #region Static Members
        public static CardSet CoreSet = new Sets.Core.CoreSet();
        public static CardSet TheHuntForGollum = new Sets.ShadowsOfMirkwood.TheHuntForGollumSet();
        public static CardSet ConflictAtTheCarrock = new Sets.ShadowsOfMirkwood.ConflictAtTheCarrockSet();
        public static CardSet AJourneyToRhosgobel = new Sets.ShadowsOfMirkwood.AJourneyToRhosgobelSet();
        public static CardSet TheHillsOfEmynMuil = new Sets.ShadowsOfMirkwood.TheHillsOfEmynMuilSet();
        public static CardSet TheDeadMarshes = new Sets.ShadowsOfMirkwood.TheDeadMarshesSet();
        public static CardSet ReturnToMirkwood = new Sets.ShadowsOfMirkwood.ReturnToMirkwoodSet();
        
        public static CardSet KhazadDum = new Sets.KhazadDum.KhazadDumSet();
        public static CardSet TheRedhornGate = new Sets.Dwarrowdelf.TheRedhornGateSet();
        public static CardSet RoadToRivendell = new Sets.Dwarrowdelf.RoadToRivendellSet();
        public static CardSet TheWatcherInTheWater = new Sets.Dwarrowdelf.TheWatcherInTheWaterSet();
        public static CardSet TheLongDark = new Sets.Dwarrowdelf.TheLongDarkSet();
        public static CardSet FoundationsOfStone = new Sets.Dwarrowdelf.FoundationsOfStoneSet();
        public static CardSet ShadowAndFlame = new Sets.Dwarrowdelf.ShadowAndFlameSet();

        public static CardSet HeirsOfNumenor = new Sets.HeirsOfNumenor.HeirsOfNumenorSet();
        public static CardSet TheStewardsFear = new Sets.AgainstTheShadow.TheStewardsFearSet();
        public static CardSet TheDruadanForest = new Sets.AgainstTheShadow.TheDruadanForestSet();
        public static CardSet EncounterAtAmonDin = new Sets.AgainstTheShadow.EncounterAtAmonDinSet();
        public static CardSet AssaultOnOsgiliath = new Sets.AgainstTheShadow.AssaultOnOsgiliathSet();
        public static CardSet TheBloodOfGondor = new Sets.AgainstTheShadow.TheBloodOfGondorSet();
        public static CardSet TheMorgulVale = new Sets.AgainstTheShadow.TheMorgulValeSet();

        public static CardSet TheVoiceOfIsengard = new Sets.TheVoiceOfIsengard.TheVoiceOfIsengardSet();
        public static CardSet TheDunlandTrap = new Sets.TheRingMaker.TheDunlandTrapSet();
        public static CardSet TheThreeTrials = new Sets.TheRingMaker.TheThreeTrialsSet();
        public static CardSet TroubleInTharbad = new Sets.TheRingMaker.TroubleInTharbadSet();
        public static CardSet TheNinInEilph = new Sets.TheRingMaker.TheNinInEilphSet();
        public static CardSet CelebrimborsSecret = new Sets.TheRingMaker.CelebrimborsSecretSet();
        public static CardSet TheAntleredCrown = new Sets.TheRingMaker.TheAntleredCrownSet();

        public static CardSet TheLostRealm = new Sets.TheLostRealm.TheLostRealmSet();
        public static CardSet TheWastesOfEriador = new Sets.AngmarAwakened.TheWastesOfEriadorSet();
        public static CardSet EscapeFromMountGram = new Sets.AngmarAwakened.EscapeFromMountGramSet();
        public static CardSet AcrossTheEttenmoors = new Sets.AngmarAwakened.AcrossTheEttenmoorsSet();
        public static CardSet TheTreacheryOfRhudaur = new Sets.AngmarAwakened.TheTreacheryOfRhudaurSet();
        public static CardSet TheBattleOfCarnDum = new Sets.AngmarAwakened.TheBattleOfCarnDumSet();
        public static CardSet TheDreadRealm = new Sets.AngmarAwakened.TheDreadRealmSet();

        public static CardSet TheGreyHavens = new Sets.TheGreyHavens.TheGreyHavensSet();
        public static CardSet FlightOfTheStormcaller = new Sets.DreamChaser.FlightOfTheStormcallerSet();
        public static CardSet TheThingInTheDepths = new Sets.DreamChaser.TheThingInTheDepthsSet();
        public static CardSet TempleOfTheDeceived = new Sets.DreamChaser.TempleOfTheDeceivedSet();
        public static CardSet TheDrownedRuins = new Sets.DreamChaser.TheDrownedRuinsSet();
        public static CardSet AStormOnCobasHaven = new Sets.DreamChaser.AStormOnCobasHavenSet();
        public static CardSet TheCityOfCorsairs = new Sets.DreamChaser.TheCityOfCorsairsSet();

        public static CardSet TheSandsOfHarad = new Sets.TheSandsOfHarad.TheSandsOfHaradSet();
        public static CardSet TheMumakil = new Sets.Haradrim.TheMumakilSet();
        public static CardSet RaceAcrossHarad = new Sets.Haradrim.RaceAcrossHaradSet();
        public static CardSet BeneathTheSands = new Sets.Haradrim.BeneathTheSandsSet();
        public static CardSet TheBlackSerpent = new Sets.Haradrim.TheBlackSerpentSet();
        public static CardSet TheDungeonsOfCirithGurat = new Sets.Haradrim.TheDungeonsOfCirithGuratSet();
        public static CardSet TheCrossingsOfPoros = new Sets.Haradrim.TheCrossingsOfPorosSet();

        public static CardSet TheWildsOfRhovanion = new Sets.TheWildsOfRhovanion.TheWildsOfRhovanionSet();
        public static CardSet TheWitheredHeath = new Sets.EredMithrin.TheWitheredHeathSet();
        public static CardSet RoamAcrossRhovanion = new Sets.EredMithrin.RoamAcrossRhovanionSet();
        public static CardSet FireInTheNight = new Sets.EredMithrin.FireInTheNightSet();
        public static CardSet TheGhostOfFramsburg = new Sets.EredMithrin.TheGhostOfFramsburgSet();
        public static CardSet MountGundabad = new Sets.EredMithrin.MountGundabadSet();
        public static CardSet TheFateOfWilderland = new Sets.EredMithrin.TheFateOfWilderlandSet();

        public static CardSet AShadowInTheEast = new Sets.AShadowInTheEast.AShadowInTheEastSet();
        public static CardSet WrathAndRuin = new Sets.VengeanceOfMordor.WrathAndRuinSet();
        public static CardSet TheCityOfUlfast = new Sets.VengeanceOfMordor.TheCityOfUlfastSet();
        public static CardSet ChallengeOfTheWainriders = new Sets.VengeanceOfMordor.ChallengeOfTheWainridersSet();
        public static CardSet UnderTheAshMountains = new Sets.VengeanceOfMordor.UnderTheAshMountainsSet();
        public static CardSet TheLandOfSorrow = new Sets.VengeanceOfMordor.TheLandOfSorrowSet();
        public static CardSet TheFortressOfNurn = new Sets.VengeanceOfMordor.TheFortressOfNurnSet();

        public static CardSet WrathAndRuinPreorderPromotion = new Sets.PreorderPromotion.WrathAndRuinPreorderPromotionSet();
        public static CardSet TheCityOfUlfastPreorderPromotion = new Sets.PreorderPromotion.TheCityOfUlfastPreorderPromotionSet();
        public static CardSet ChallengeOfTheWainridersPreorderPromotion = new Sets.PreorderPromotion.ChallengeOfTheWainridersPreorderPromotionSet();
        public static CardSet UnderTheAshMountainsPreorderPromotion = new Sets.PreorderPromotion.UnderTheAshMountainsPreorderPromotionSet();

        public static CardSet TheHobbitOverHillAndUnderHill = new Sets.TheHobbit.OverHillandUnderHillSet();
        public static CardSet TheHobbitOnTheDoorstep = new Sets.TheHobbit.OntheDoorstepSet();

        public static CardSet TheBlackRiders = new Sets.TheLordOfTheRings.TheBlackRidersSet();
        public static CardSet TheRoadDarkens = new Sets.TheLordOfTheRings.TheRoadDarkens();
        public static CardSet TheTreasonOfSaruman = new Sets.TheLordOfTheRings.TheTreasonOfSaruman();
        public static CardSet TheLandOfShadow = new Sets.TheLordOfTheRings.TheLandOfShadow();
        public static CardSet TheFlameOfTheWest = new Sets.TheLordOfTheRings.TheFlameOfTheWestSet();
        public static CardSet TheMountainOfFire = new Sets.TheLordOfTheRings.TheMountainOfFire();

        public static CardSet TwoPlayerLimitedEditionStarter = new Sets.Starter.TwoPlayerLimitedEditionStarterSet();

        public static CardSet TheMassingAtOsgiliath = new Sets.PrintOnDemand.TheMassingatOsgiliath();
        public static CardSet TheBattleOfLakeTown = new Sets.PrintOnDemand.TheBattleofLakeTown();
        public static CardSet TheStoneOfErech = new Sets.PrintOnDemand.TheStoneofErech();
        public static CardSet TheRuinsOfBelegost = new Sets.PrintOnDemand.TheRuinsOfBelegost();
        public static CardSet TheSiegeOfAnnuminas = new Sets.PrintOnDemand.TheSiegeOfAnnuminas();
        public static CardSet AttackOnDolGuldur = new Sets.PrintOnDemand.AttackOnDolGuldurSet();
        public static CardSet TheWizardsQuest = new Sets.PrintOnDemand.TheWizardsQuestSet();
        public static CardSet TheWoodlandRealm = new Sets.PrintOnDemand.TheWoodlandRealmSet();
        public static CardSet EscapeFromKhazadDum = new Sets.PrintOnDemand.EscapeFromKhazadDumSet();
        public static CardSet EscapeFromKhazadDumPreorderPromotion = new Sets.PreorderPromotion.EscapeFromKhazadDumPreorderPromotionSet();

        public static CardSet PassageThroughMirkwoodNightmare = new Sets.Core.PassageThroughMirkwoodNightmareSet();
        public static CardSet JourneyAlongTheAnduinNightmare = new Sets.Core.JourneyAlongTheAnduinNightmareSet();
        public static CardSet EscapeFromDolGuldurNightmare = new Sets.Core.EscapeFromDolGuldurNightmareSet();

        public static CardSet TheHuntForGollumNightmare = new Sets.ShadowsOfMirkwood.TheHuntForGollumNightmareSet();
        public static CardSet ConflictAtTheCarrockNightmare = new Sets.ShadowsOfMirkwood.ConflictAtTheCarrockNightmare();
        public static CardSet AJourneyToRhosgobelNightmare = new Sets.ShadowsOfMirkwood.AJourneyToRhosgobelNightmare();
        public static CardSet TheHillsOfEmynMuilNightmare = new Sets.ShadowsOfMirkwood.TheHillsOfEmynMuilNightmare();
        public static CardSet TheDeadMarshesNightmare = new Sets.ShadowsOfMirkwood.TheDeadMarshesNightmare();
        public static CardSet ReturnToMirkwoodNightmare = new Sets.ShadowsOfMirkwood.ReturnToMirkwoodNightmare();

        public static CardSet IntoThePitNightmare = new Sets.KhazadDum.IntoThePitNightmare();
        public static CardSet TheSeventhLevelNightmare = new Sets.KhazadDum.TheSeventhLevelNightmare();
        public static CardSet FlightFromMoriaNightmare = new Sets.KhazadDum.FlightFromMoriaNightmare();

        public static CardSet TheRedhornGateNightmare = new Sets.Dwarrowdelf.TheRedhornGateNightmare();
        public static CardSet RoadToRivendellNightmare = new Sets.Dwarrowdelf.RoadToRivendellNightmare();
        public static CardSet TheWatcherInTheWaterNightmare = new Sets.Dwarrowdelf.TheWatcherInTheWaterNightmare();
        public static CardSet TheLongDarkNightmare = new Sets.Dwarrowdelf.TheLongDarkNightmare();
        public static CardSet FoundationsOfStoneNightmare = new Sets.Dwarrowdelf.FoundationsOfStoneNightmare();
        public static CardSet ShadowAndFlameNightmare = new Sets.Dwarrowdelf.ShadowAndFlameNightmare();

        public static CardSet PerilInPelargirNightmare = new Sets.HeirsOfNumenor.PerilInPelargirNightmare();
        public static CardSet IntoIthilienNightmare = new Sets.HeirsOfNumenor.IntoIthilienNightmare();
        public static CardSet TheSiegeOfCairAndrosNightmare = new Sets.HeirsOfNumenor.TheSiegeOfCairAndrosNightmare();

        public static CardSet TheStewardsFearNightmare = new Sets.AgainstTheShadow.TheStewardsFearNightmare();
        public static CardSet TheDruadanForestNightmare = new Sets.AgainstTheShadow.TheDruadanForestNightmare();
        public static CardSet EncounterAtAmonDinNightmare = new Sets.AgainstTheShadow.EncounterAtAmonDinNightmare();
        public static CardSet AssaultOnOsgiliathNightmare = new Sets.AgainstTheShadow.AssaultOnOsgiliathNightmare();
        public static CardSet TheBloodOfGondorNightmare = new Sets.AgainstTheShadow.TheBloodOfGondorNightmare();
        public static CardSet TheMorgulValeNightmare = new Sets.AgainstTheShadow.TheMorgulValeNightmare();

        public static CardSet TheFordsOfIsenNightmare = new Sets.TheVoiceOfIsengard.TheFordsOfIsenNightmare();
        public static CardSet ToCatchAnOrcNightmare = new Sets.TheVoiceOfIsengard.ToCatchAnOrcNightmare();
        public static CardSet IntoFangornNightmare = new Sets.TheVoiceOfIsengard.IntoFangornNightmare();

        public static CardSet TheDunlandTrapNightmare = new Sets.TheRingMaker.TheDunlandTrapNightmare();
        public static CardSet TheThreeTrialsNightmare = new Sets.TheRingMaker.TheThreeTrialsNightmare();
        public static CardSet TroubleInTharbadNightmare = new Sets.TheRingMaker.TroubleInTharbadNightmare();
        public static CardSet TheNinInEilphNightmare = new Sets.TheRingMaker.TheNinInEilphNightmare();
        public static CardSet CelebrimborsSecretNightmare = new Sets.TheRingMaker.CelebrimborsSecretNightmare();
        public static CardSet TheAntleredCrownNightmare = new Sets.TheRingMaker.TheAntleredCrownNightmare();

        public static CardSet IntrudersInChetwoodNightmare = new Sets.TheLostRealm.IntrudersInChetwoodNightmareSet();
        public static CardSet TheWeatherHillsNightmare = new Sets.TheLostRealm.TheWeatherHillsNightmareSet();
        public static CardSet DeadmensDikeNightmare = new Sets.TheLostRealm.DeadmensDikeNightmareSet();
        
        public static CardSet TheWastesOfEriadorNightmare = new Sets.AngmarAwakened.TheWastesOfEriadorNightmare();
        public static CardSet EscapeFromMountGramNightmare = new Sets.AngmarAwakened.EscapeFromMountGramNightmareSet();
        public static CardSet AcrossTheEttenmoorsNightmare = new Sets.AngmarAwakened.AcrossTheEttenmoorsNightmareSet();
        public static CardSet TheTreacheryOfRhudaurNightmare = new Sets.AngmarAwakened.TheTreacheryOfRhudaurNightmare();
        public static CardSet TheBattleOfCarnDumNightmare = new Sets.AngmarAwakened.TheBattleOfCarnDumNightmareSet();
        public static CardSet TheDreadRealmNightmare = new Sets.AngmarAwakened.TheDreadRealmNightmare();

        public static CardSet VoyageAcrossBelegaerNightmare = new Sets.TheGreyHavens.VoyageAcrossBelegaerNightmare();
        public static CardSet TheFateOfNumenorNightmare = new Sets.TheGreyHavens.TheFateOfNumenorNightmare();
        public static CardSet RaidOnTheGreyHavensNightmare = new Sets.TheGreyHavens.RaidOnTheGreyHavensNightmareSet();

        public static CardSet FlightOfTheStormcallerNightmare = new Sets.DreamChaser.FlightOfTheStormcallerNightmare();
        public static CardSet TheThingInTheDepthsNightmare = new Sets.DreamChaser.TheThingInTheDepthsNightmare();
        public static CardSet TempleOfTheDeceivedNightmare = new Sets.DreamChaser.TempleOfTheDeceivedNightmareSet();
        public static CardSet TheDrownedRuinsNightmare = new Sets.DreamChaser.TheDrownedRuinsNightmareSet();
        public static CardSet AStormOnCobasHavenNightmare = new Sets.DreamChaser.AStormOnCobasHavenNightmareSet();
        public static CardSet TheCityOfCorsairsNightmare = new Sets.DreamChaser.TheCityOfCorsairsNightmareSet();

        public static CardSet WeMustAwayEreBreakOfDayNightmare = new Sets.TheHobbit.WeMustAwayEreBreakOfDayNightmare();
        public static CardSet OverTheMistyMountainsGrimNightmare = new Sets.TheHobbit.OverTheMistyMountainsGrimNightmare();
        public static CardSet DungeonsDeepAndCavernsDimNightmare = new Sets.TheHobbit.DungeonsDeepAndCavernsDimNightmare();
        public static CardSet FliesAndSpidersNightmare = new Sets.TheHobbit.FliesAndSpidersNightmare();
        public static CardSet TheLonelyMountainNightmare = new Sets.TheHobbit.TheLonelyMountainNightmare();
        public static CardSet TheBattleOfFiveArmiesNightmare = new Sets.TheHobbit.TheBattleOfFiveArmiesNightmare();

        public static CardSet AShadowOfThePastNightmare = new Sets.TheLordOfTheRings.AShadowOfThePastNightmare();
        public static CardSet AKnifeInTheDarkNightmare = new Sets.TheLordOfTheRings.AKnifeInTheDarkNightmare();
        public static CardSet FlightToTheFordNightmare = new Sets.TheLordOfTheRings.FlightToTheFordNightmare();
        public static CardSet TheRingGoesSouthNightmare = new Sets.TheLordOfTheRings.TheRingGoesSouthNightmare();
        public static CardSet JourneyInTheDarkNightmare = new Sets.TheLordOfTheRings.JourneyInTheDarkNightmare();
        public static CardSet BreakingOfTheFellowshipNightmare = new Sets.TheLordOfTheRings.BreakingOfTheFellowshipNightmare();

        public static CardSet TheUrukHaiNightmare = new Sets.TheLordOfTheRings.TheUrukHaiNightmare();
        public static CardSet HelmsDeepNightmare = new Sets.TheLordOfTheRings.HelmsDeepNightmareSet();
        public static CardSet TheRoadToIsengardNightmare = new Sets.TheLordOfTheRings.TheRoadToIsengardNightmareSet();

        public static CardSet ThePassageOfTheMarshesNightmare = new Sets.TheLordOfTheRings.ThePassageOfTheMarshesNightmareSet();
        public static CardSet JourneyToTheCrossRoadsNightmare = new Sets.TheLordOfTheRings.JourneyToTheCrossRoadsNightmareSet();
        public static CardSet ShelobsLairNightmare = new Sets.TheLordOfTheRings.ShelobsLairNightmareSet();

        public static CardSet TheOldForest = new Sets.PrintOnDemand.TheOldForest();
        public static CardSet FogOnTheBarrowDowns = new Sets.PrintOnDemand.FogOnTheBarrowDowns();
        public static CardSet MurderAtThePrancingPony = new Sets.PrintOnDemand.MurderAtThePrancingPony();

        public static CardSet FirstAge = new Sets.FirstAge.FirstAgeSet();
        public static CardSet TrialUponTheMarches = new Sets.FirstAge.TrialUponTheMarchesSet();
        public static CardSet AmongTheOutlaws = new Sets.FirstAge.AmongTheOutlawsSet();
        #endregion
    }
}