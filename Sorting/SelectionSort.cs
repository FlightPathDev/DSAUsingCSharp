using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSAProblemSolve.Sorting
{
    internal class SelectionSort
    {
        public SelectionSort()
        {
            #region Ascending Order
            int[] arr = { 4, 56, 8, 2, 56, 14, 6, 5, 2, 56, 14, 5 };

            // printing the array
            Console.WriteLine(string.Join(",", arr));

            int len = arr.Length;
            //Sorting in Increasing order
            for (int i = 0; i < len - 1; i++)
            {
                int m = arr[i];
                int pos = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < m)
                    {
                        m = arr[j];
                        pos = j;
                    }
                }
                arr[pos] = arr[i];
                arr[i] = m;
            }

            // printing the sorted array
            Console.WriteLine(string.Join(",", arr));
            #endregion

            #region Descending Order
            int[] arr1 = { 4, 56, 8, 2, 56, 14, 6, 5, 2, 56, 14, 5 };

            // printing the array
            Console.WriteLine(string.Join(",", arr1));

            int len1 = arr1.Length;
            //Sorting in Decreasing order
            for (int i = 0; i < len1 - 1; i++)
            {
                int m = arr1[i];
                int pos = i;
                for (int j = i + 1; j < len1; j++)
                {
                    if (arr1[j] > m)
                    {
                        m = arr[j];
                        pos = j;
                    }
                }
                arr[pos] = arr1[i];
                arr1[i] = m;
            }

            // printing the sorted array
            Console.WriteLine(string.Join(",", arr1));
            #endregion
        }
    }
}
