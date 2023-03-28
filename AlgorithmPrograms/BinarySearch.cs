using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class BinarySearch
    {
        public static int BinarySearchDemo(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            //Console.WriteLine("end=" + end);
            while (start <= end) //5<=6
            {
                int mid = (end + start) / 2;//calcute mid here mid=4 =30   //mid ==7  //mid= 5
                //Console.WriteLine("mid=="+mid+ "\n");
                if (arr[mid] == target) //target got 
                {
                    return mid;
                }
                else if (arr[mid] < target) // target in right half of array
                {
                    start = mid + 1; //mid=star=5  


                }
                else                     // target in left array
                {
                    end = mid - 1; // end= 6

                }

                //return -1; // target not found
            }
            return default;

        }



    }
}
