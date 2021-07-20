using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class CategoriesTranslation
    {
        public int Id { set; get; }
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public int LaguageId { set; get; }
        public string SeoAlias { set; get; }

    }
}
