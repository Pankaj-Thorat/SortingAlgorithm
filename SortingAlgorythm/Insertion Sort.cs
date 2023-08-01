using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythm
{
    internal class Insertion_Sort
    {
        public void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }

        }

        public void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();

        }
    }
}
