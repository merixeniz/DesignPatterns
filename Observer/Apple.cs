using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Apple : ASubject
    {
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        

        public void ChangePrice(float price)
        {
            Notify(price);
            this.price = price;
        }
    }
}
