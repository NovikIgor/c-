using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateNewArrayOfLengthContainingSomeElements_52
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 52 Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.

            int num1, num2, num3;
            int[] arr1 = { 3, 7, 9 };
            int[] arr2 = { 11, 2, 19 };
            int[] arr3 = { 6, 15, 37 };

            Console.WriteLine("Array #1: [{0}]", string.Join(", ", arr1));
            Console.WriteLine("Array #2: [{0}]", string.Join(", ", arr2));
            Console.WriteLine("Array #3: [{0}]", string.Join(", ", arr3));

            num1 = arr1[1];
            num2 = arr2[1];
            num3 = arr3[1];

            //int[] new_array = { array1[1], array2[1], array3[1] };
            //Console.WriteLine("New array: [{0}]", string.Join(", ", new_array));

            Console.WriteLine("New array is:\n [{0}, {1}, {2}]", num1, num2, num3);
            Console.ReadKey();
        }
    }
}
