using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAProblemSolve.Sorting
{
    internal class CountingSort
    {
        public CountingSort()
        {
            int[] arr = { 4, 56, 8, 2, 56, 14, 6, 5, 2, 56, 14, 5, 89, 1 };

            // printing the original array
            Console.WriteLine(string.Join(",", arr));

            int len = arr.Length;

            // Find the largest element of the array
            int max = arr[0];
            for (int i = 1; i <= len - 1; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            int[] count = new int[max + 1];

            // Initialize count array with all zeros. (This is Optional in java)
            for (int i = 0; i <= count.Length - 1; ++i)
            {
                count[i] = 0;
            }

            // Store the count of each element
            for (int i = 0; i <= len - 1; i++)
            {
                count[arr[i]]++;
            }

            // Store the cumulative count of each array
            for (int i = 1; i <= count.Length - 1; i++)
            {
                count[i] = count[i] + count[i - 1]; //or  //count[i] += count[i-1];
            }

            // Find the index of each element of the original array in count array, and
            // place the elements in output array
            int[] output = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                count[arr[i]]--;
                output[count[arr[i]]] = arr[i];
            }

            arr = output;

            // printing the sorted array
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
