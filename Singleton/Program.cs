using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int nCounter = 0; nCounter < 10; ++nCounter)
            {                
                Console.WriteLine("Iteracja {0}", nCounter + 1);
                //Singleton.Instance.DoSomething();
                SingletonSecured.Instance.DoSomething();
                
            }
        Console.ReadKey();
        }
    }
}
