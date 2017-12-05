using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndLastElementsInArrayAreEqual_48
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 48 Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.

            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 8, 8, 9, 1 };
            
            Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));
            Console.ReadKey();
        }
    }
}
