using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple product = new Apple();

            Shop shop1 = new Shop("Shop1");
            Shop shop2 = new Shop("Shop2");
            Shop shop3 = new Shop("Shop3");
            Shop shop4 = new Shop("Shop4");

            product.Attach(shop1);
            product.Attach(shop2);
            product.Attach(shop3);

            product.ChangePrice(15.00f);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(product.Price);

            product.Detach(shop3);

            product.ChangePrice(19.99f);

            Console.ReadKey();
        }
    }
}
