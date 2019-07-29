using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MergeSort : ISortingStrategy
    {
        public void Sort<T>(List<T> dataToSort)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Merge sorting in progress. . . ");
        }
    }
}
