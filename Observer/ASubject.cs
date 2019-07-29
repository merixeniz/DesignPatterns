using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ASubject
    {
        List<Shop> shopList = new List<Shop>();

        public void Attach(Shop shop)
        {
            shopList.Add(shop);
        }

        public void Detach(Shop shop)
        {
            shopList.Remove(shop);
        }

        public void Notify(float price)
        {
            foreach (var item in shopList)
            {
                item.Update(price);
            }
        }
    }
}
