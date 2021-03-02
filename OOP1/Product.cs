using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } // ürün adı
        public double UnitPrice { get; set; } // ürün birim fiyatı
        public int UnitsInStock { get; set; } // ürün stok adedi


    }
}
