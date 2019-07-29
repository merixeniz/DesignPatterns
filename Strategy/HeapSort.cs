using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class HeapSort : ISortingStrategy
    {
        public void Sort<T>(List<T> dataToSort)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Heap sorting in progress . . .");
        }
    }
}
