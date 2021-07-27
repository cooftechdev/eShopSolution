﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public Status ApplyForAll { set; get; }
        public int DiscountPercent { set; get; }
        public decimal DiscountAmount { set; get; }
        public int ProductIds { set; get; }
        public int ProductCategoryIds { set; get; }
        public Status Status { set; get; }
        public string Name { set; get; }

    }
}
