using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // encapsulation
        public void Add(Product product) // fazla parametreler kullanmak yerine tamamının bir yerde bulunduğu bir class kullanmak
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
      
    }
}
