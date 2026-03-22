using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAProblemSolve.Sorting
{
    internal class RadixSort
    {
        public RadixSort()
        {
            int[] arr = { 4, 56, 8, 2, 56, 14, 6, 5, 121, 56, 114, 5, 89, 1 };

            int len = arr.Length;

            //find max value in given array
            int max = arr[0];
            for (int i = 1; i <= len - 1; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            //find number of digits in max value
            int radixCount = 0;
            while (max != 0)
            {
                radixCount++;
                max = max / 10;
            }
            //now sorting starts
            int div = 1;
            for (int i = 1; i <= radixCount; i++)
            {
                int[] bucketsCounts = new int[10];
                int[,] buckets = new int[10, len];
                for (int j = 0; j <= len - 1; j++)
                {
                    int k = (arr[j] / div) % 10;
                    buckets[k, bucketsCounts[k]] = arr[j];
                    bucketsCounts[k]++;
                }
                int pos = 0;
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= bucketsCounts[j] - 1; k++)
                    {
                        arr[pos] = buckets[j, k];
                        pos++;
                    }
                }
                div = div * 10;
            }
            //now sorting ends

            //printing the sorted array
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
