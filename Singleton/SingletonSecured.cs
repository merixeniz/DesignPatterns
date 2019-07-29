using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonSecured
    {
        private static SingletonSecured newInstance;
        private int Counter = 0;

        private static readonly object locking = new object();

        public static SingletonSecured Instance 
        {
           get 
           {
               lock (locking)
               {
                   if (newInstance == null)
                       newInstance = new SingletonSecured();
               }
                   return newInstance;
           }
            
        }

        public void DoSomething()
        {
            Console.WriteLine("Wartość licznika: {0}", Counter);
        }


        private SingletonSecured()
        {
            Counter = 1;
        }
    }
}
