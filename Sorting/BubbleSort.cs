using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAProblemSolve.Sorting
{
    internal class BubbleSort
    {
        public BubbleSort()
        {
            #region Ascending Order
            int[] arr = { 4, 56, 8, 2, 56, 14, 6, 5, 2, 56, 14, 5 };

            // printing the array
            Console.WriteLine(string.Join(",", arr));

            int len = arr.Length;
            //Sorting in Increasing order
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swapping
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            #endregion

            #region Descending Order
            //printing the sorted array
            Console.WriteLine(string.Join(",", arr));

            int[] arr1 = { 4, 56, 8, 2, 56, 14, 6, 5, 2, 56, 14, 5 };

            // printing the array
            Console.WriteLine(string.Join(",", arr1));

            int len1 = arr.Length;
            //Sorting in Decreasing order
            for (int i = 0; i < len1 - 1; i++)
            {
                for (int j = 0; j < len1 - i - 1; j++)
                {
                    if (arr1[j] < arr1[j + 1])
                    {
                        // swapping
                        int temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }

            // printing the sorted array
            Console.WriteLine(string.Join(",", arr1));
            #endregion
        }
    }
}
