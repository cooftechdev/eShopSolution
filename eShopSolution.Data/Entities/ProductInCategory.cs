using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class ProductInCategory // Quan hệ nhiều nhiều
    {
        public int ProductId { set; get; }
        public Product Product { set; get; } // Thuộc tính liên kết đến product
        public int CategoryId { set; get; }
        public Category Category { set; get; } // Thuộc tính liên kết đến category
    }
}
