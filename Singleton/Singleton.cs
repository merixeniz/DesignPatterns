using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        private static Singleton newInstance = null;
        private int Counter = 0;

        public static Singleton Instance
        {
           get
            {
                if ((newInstance == null))
                {
                    newInstance = new Singleton();                    
                }
                return newInstance;
            }
        }
        public void DoSomething()
        {
            Console.WriteLine("Counter value: {0}", Counter++);
        }
        
        private Singleton()
        {
            Counter = 1;
        }
    }
}
