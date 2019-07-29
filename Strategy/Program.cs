using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {      
        static void Main(string[] args)
        {
            ISortingStrategy sortingStrategy = null;

            List<string> voivodeshipResidence = new List<string> { "ab", "ac", "xa", "td" };
            sortingStrategy = GetSortingOption(ObjectToSort.NazwiskoMieszkanca);
            sortingStrategy.Sort(voivodeshipResidence);

            List<int> studentNumbers = new List<int> { 123456, 9876543, 345432 };
            sortingStrategy = GetSortingOption(ObjectToSort.NumerAlbumuStudenta);
            sortingStrategy.Sort(studentNumbers);

            List<string> cityCartNumbers = new List<string> { "A123456", "B9876543", "C345432" };
            sortingStrategy = GetSortingOption(ObjectToSort.NumerKartyMiejskiej);
            sortingStrategy.Sort(cityCartNumbers);

            Console.ReadKey();
        }

        private static ISortingStrategy GetSortingOption(ObjectToSort objectToSort)
        {
            ISortingStrategy sortingStrategy = null;

            switch (objectToSort)
            {
                case ObjectToSort.NumerAlbumuStudenta:
                    sortingStrategy = new MergeSort();
                    break;
                case ObjectToSort.NumerKartyMiejskiej:
                    sortingStrategy = new HeapSort();
                    break;
                case ObjectToSort.NazwiskoMieszkanca:
                    sortingStrategy = new QuickSort();
                    break;
                default:
                    break;
            }
            return sortingStrategy;
        }
    }
}
