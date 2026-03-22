using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAProblemSolve.Sorting
{
    internal class InsertionSort
    {
        public InsertionSort()
        {
            #region Ascending Order
            int[] arr = { 4, 56, 8, 2, 56, 14, 6, 5, 2, 56, 14, 5 };
            // printing the array
            Console.WriteLine(string.Join(",", arr));

            int len = arr.Length;
            //Sorting in Increasing order
            for (int i = 1; i < len; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            //printing the sorted array
            Console.WriteLine(string.Join(",", arr));
            #endregion

            #region  Descending Order
            int[] arr1 = { 4, 56, 8, 2, 56, 14, 6, 5, 2, 56, 14, 5 };
            // printing the array
            Console.WriteLine(string.Join(",", arr1));

            int len1 = arr1.Length;
            //Sorting in Decreasing order
            for (int i = 1; i < len1; i++)
            {
                int key = arr1[i];
                int j = i - 1;
                while (j >= 0 && key > arr1[j])
                {
                    arr1[j + 1] = arr1[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            //printing the sorted array
            Console.WriteLine(string.Join(",", arr1));
            #endregion
        }
    }
}
