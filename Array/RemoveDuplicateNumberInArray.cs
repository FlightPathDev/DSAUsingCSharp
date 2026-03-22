using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAProblemSolve.Array
{
    internal class RemoveDuplicateNumberInArray
    {
        public RemoveDuplicateNumberInArray()
        {
            int[] arr = { 2, 7, 1, 5, 8, 47, 10, 8, 1, 40, 47, 48 };
            Console.WriteLine(string.Join(", ", arr));   
            //Array.Sort(arr);
            int j = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    arr[j++] = arr[i + 1];
                }
            }
            int[] newArr = new int[j];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
