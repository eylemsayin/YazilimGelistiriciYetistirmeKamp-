using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BasketManager
    {
        //naming Convention
        //syntax
        public void Add( Product product)
        {
            Console.WriteLine("Tebrikler, sepete ürününüz eklendi: " +product.Name );
        }

        public void Add2(string productName, string description, double price, int amountOfStock)
        {
            Console.WriteLine("Tebrikler, sepete ürününüz eklendi: " + productName);
        }
    }
}
