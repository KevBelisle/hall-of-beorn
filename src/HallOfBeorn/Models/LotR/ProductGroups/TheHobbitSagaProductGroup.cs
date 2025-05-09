﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheHobbitSagaProductGroup : ProductGroup
    {
        public TheHobbitSagaProductGroup()
            : base("The Hobbit Saga")
        {
            AddChildProduct(Product.TheHobbitOverHillAndUnderHill);
            AddChildProduct(Product.TheHobbitOnTheDoorstep);
        }
    }
}