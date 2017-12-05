using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СountІSpecifiedNumberInGivenArrayOfIntegers_45
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 45 Write a C# program to count a specified number in a given array of integers.

            Console.WriteLine("\nInput an integer:");
            int x = int.Parse(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine("Number of " + x + " present in the said array:");
            Console.WriteLine(nums.Count(n => n == x));
            Console.ReadLine();
        }
    }
}
