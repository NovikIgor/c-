using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstElementAreEqualInTwoArrays_49
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 49 Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.

            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 8, 8, 9, 5 };

            if (nums.Length > 1 && nums1.Length > 1)
            {
                Console.WriteLine("First numbers are equals?: ");
                Console.WriteLine((nums[0].Equals(nums1[0])));
                Console.WriteLine("Second numbers are equals?: ");
                Console.WriteLine((nums[nums.Length - 1].Equals(nums1[nums1.Length - 1])));
            }
            else
            {
                Console.WriteLine("Too small arrays!");
            }
            Console.ReadKey();
        }
    }
}
