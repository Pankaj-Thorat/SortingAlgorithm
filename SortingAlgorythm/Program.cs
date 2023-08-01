using SortingAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 13, 14, 15 };

            Insertion_Sort sort = new Insertion_Sort();
            Console.WriteLine("Before Sorting");
            sort.PrintArray(array);

            sort.InsertionSort(array);
            Console.WriteLine("After sorting");
            sort.PrintArray(array);
        }

       
    }
}
