using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{

    // int double float değer tip
    // class interface abstract class referans tipkerdir
    class PruductManager //manager görürsek içinde operasyonlar vardır. Ekleme silme gibi
    {

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
         }




    }
}