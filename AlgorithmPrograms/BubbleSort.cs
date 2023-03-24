using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class BubbleSort
    {
        public static void doBubbleSort(int[] array)
        {
            int temp;
            Console.WriteLine("The original Array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    //elements in arreay are: 5, 2, 6, 
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1]; //temp=2
                        array[i + 1] = array[i]; //  5 2 6
                        array[i] = temp; // 2 5 6
                    }
                }
            }
        }
    }

}
