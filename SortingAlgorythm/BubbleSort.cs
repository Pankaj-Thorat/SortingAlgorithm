using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythm
{
     class BubbleSort
    {

        public void bubbleSort(int[] array)

        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[ j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void printArray(int[] array)
        {
            foreach (int item in array)
                Console.Write(item + " ");
        }
    }
}
