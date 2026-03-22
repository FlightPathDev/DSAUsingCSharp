using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAProblemSolve.Array
{
    internal class FindDuplicateNumberInArray
    {
        public FindDuplicateNumberInArray()
        {
            int[] arr = { 2, 7, 1, 5, 8, 47, 10, 8, 1, 40, 47, 48 };

            int j = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    arr[j++] = arr[i];
                }
            }
            int[] duplicate = new int[j];
            for (int k = 0; k < duplicate.Length - 1; k++)
            {
                duplicate[k] = arr[k];
            }
            Console.WriteLine(string.Join(",", duplicate));
        }
    }
}
