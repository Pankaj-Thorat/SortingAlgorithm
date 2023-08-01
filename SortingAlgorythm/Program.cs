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

            Console.WriteLine("Before Sorting");
            PrintArray(array);

            InsertionSort(array);
            Console.WriteLine("After sorting");
            PrintArray(array);
        }

        static void InsertionSort(int[] array)
        {
            for(int i =1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >=0 && array[j]> key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j +1] = key;
            }

        }

        static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();

        }
    }
}
