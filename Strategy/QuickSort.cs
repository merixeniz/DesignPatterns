using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class QuickSort : ISortingStrategy
    {
        public void Sort<T>(List<T> dataToSort)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Quick sorting in progress. . .");
        }
    }
}
