namespace HallOfBeorn.Models.LotR.Scenarios.Core
{
    public class EscapeFromDolGuldurCampaignScenario : Scenario
    {
        public EscapeFromDolGuldurCampaignScenario()
            : base(true)
        {
            Title = "Escape from Dol Guldur (Campaign)";
            ProductName = "Revised Core Set";
            GroupName = "Revised Core Set";
            Number = 3;

            QuestCompanionSlug = "core-set-quest-escape-from-dol-guldur";
            DifficultyRating = 7.8f;
            Votes = 136;

            AddProgressionSeriesLink("3", "Q6eM2DnPtHo");
            AddTheLineUnbrokenLink("3", "YnWmafDZ3_Y");
            AddTheLineUnbrokenLink("N3", "f4euaXWkbNc");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/02/12/beorns-path-part-6-escape-from-dol-guldur/");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2016/11/12/escape-from-dol-guldur-quest-analysis/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/01/21/escape-from-dol-guldur/");

            AddRelatedDeck("305", "Beorn's Path Leadership/Lore",
                "https://hallofbeorn.wordpress.com/2013/02/12/beorns-path-part-6-escape-from-dol-guldur/");
            AddRelatedDeck("305", "Beorn's Path Spirit/Tactics",
                "https://hallofbeorn.wordpress.com/2013/02/12/beorns-path-part-6-escape-from-dol-guldur/");

            AddRelatedDeck("1871", "The Line Unbroken - Core Set Deck 1",
                "https://wardenofarnor.wordpress.com/2015/03/14/the-line-unbroken-1-the-core-set/",
                "https://www.youtube.com/watch?v=YnWmafDZ3_Y");
            AddRelatedDeck("1872", "The Line Unbroken - Core Set Deck 2",
                "https://wardenofarnor.wordpress.com/2015/03/14/the-line-unbroken-1-the-core-set/",
                "https://www.youtube.com/watch?v=YnWmafDZ3_Y");
            AddRelatedDeck("5524", "Flawless Victory",
                "https://www.youtube.com/watch?v=f4euaXWkbNc");

            AddEncounterSet(EncounterSet.DolGuldurOrcsCampaign);
            AddEncounterSet(EncounterSet.EscapeFromDolGuldurCampaign);
            AddEncounterSet(EncounterSet.EscapeFromDolGuldurNightmare);
            AddEncounterSet(EncounterSet.SpidersOfMirkwoodCampaign);

            AddQuestCardId("The-Necromancer's-Tower-RevCore");
            AddQuestCardId("Through-the-Caverns-RevCore");
            AddQuestCardId("Out-of-the-Dungeons-RevCore");

            ExcludeFromEasyMode("Chieftan-Ufthak-RevCore", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-RevCore", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-RevCore", 1);
            ExcludeFromEasyMode("The-Necromancer's-Reach-RevCore", 2);
            ExcludeFromEasyMode("Dungeon-Jailor-RevCore", 2);
            ExcludeFromEasyMode("Caught-in-a-Web-RevCore", 2);
            ExcludeFromEasyMode("Eyes-of-the-Forest-RevCore", 1);
            ExcludeFromEasyMode("Hummerhorns-RevCore", 1);

            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-RevCore", 2);
            ExcludeFromNightmareMode("Enchanted-Stream-RevCore", 2);
            ExcludeFromNightmareMode("Necromancer's-Pass-RevCore", 1);
            ExcludeFromNightmareMode("The-Necromancer's-Reach-RevCore", 1);
            ExcludeFromNightmareMode("Iron-Shackles-RevCore", 1);
            ExcludeFromNightmareMode("Tower-Gate-RevCore", 2);
            ExcludeFromNightmareMode("Under-the-Shadow-RevCore", 2);
            ExcludeFromNightmareMode("Caught-in-a-Web-RevCore", 2);
            ExcludeFromNightmareMode("Great-Forest-Web-RevCore", 1);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-RevCore", 3);
        }
    }
}
