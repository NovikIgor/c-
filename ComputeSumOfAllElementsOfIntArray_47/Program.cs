using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComputeSumOfAllElementsOfIntArray_47
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 47 Write a C# program to compute the sum of all the elements of an array of integers.

            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 8, 8, 9 }; //13
            int sum = 0;
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine("Sum: {0}", sum);
            Console.ReadKey();
        }
    }
}
