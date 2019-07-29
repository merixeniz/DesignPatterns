using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Shop : IObserver
    {
        string name;
        float price = 0.0f;

        public Shop(string name)
        {
            this.name = name;
        }

        public void Update(float price)
        {
            this.price = price;
            Console.WriteLine("Cena produktu w: {0} wynosi: {1}", this.name, this.price);
        }
    }
}
