﻿using System;

namespace HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast
{
    public class DangerInDorwinionScenario : AShadowInTheEastScenario
    {
        private const string name = "Danger in Dorwinion";

        public DangerInDorwinionScenario()
        {
            Title = name;
            ProductName = "A Shadow in the East";
            GroupName = "A Shadow in the East";
            Number = 2;

            RulesImageCount = 10;

            QuestCompanionSlug = "a-shadow-in-the-east-deluxe-expansion-quest-danger-in-dorwinion";
            DifficultyRating = 5.0f;
            Votes = 7;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/10/01/danger-in-dorwinion/");

            AddEncounterSet(EncounterSet.DangerInDorwinion);
            AddEncounterSet(EncounterSet.ServantsOfSauron);
            AddEncounterSet(EncounterSet.CityOfRhun);
            AddEncounterSet(EncounterSet.UnderGuard);

            AddQuestCardId("A-City-in-Turmoil-ASitE");
            AddQuestCardId("The-Shadow-of-Mordor-ASitE");
            AddQuestCardId("Leader-of-the-Cult-ASitE");

            ExcludeDangerInDorwinionFromEasyMode();
            ExcludeServantsOfSauronFromEasyMode();
            ExcludeCityOfRhunFromEasyMode();
            ExcludeUnderGuardFromEasyMode();
        }
    }
}
