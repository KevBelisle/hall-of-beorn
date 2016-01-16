﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheHuntForGollumProduct : Product
    {
        public TheHuntForGollumProduct()
            : base("The Hunt for Gollum", "MEC02", ImageType.Png, new DateTime(2011, 7, 21))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-TheHuntForGollum.pdf";

            AddCardSet(CardSet.TheHuntForGollum);

            AddScenario(new HallOfBeorn.Models.Scenarios.TheHuntForGollum());
        }
    }
}