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


            //for insertion sort
            Insertion_Sort sort = new Insertion_Sort();
            Console.WriteLine("Before Sorting");
            sort.PrintArray(array);

            sort.InsertionSort(array);
            Console.WriteLine("After sorting");
            sort.PrintArray(array);


            // for bubble sort 
            BubbleSort sort1 = new BubbleSort();
            int[] arr = { 64, 34, 25, 12, 22, 11, 13, 14, 15 };

            Console.WriteLine("\nBefore Bubble sort");
            sort1.printArray(arr);

            sort1.bubbleSort(arr);
            Console.WriteLine("\nAfter Bubble sort");
            sort1.printArray(arr);

        }

       
    }
}
