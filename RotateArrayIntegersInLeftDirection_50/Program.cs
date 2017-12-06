using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayIntegersInLeftDirection_50
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 50  Write a C# program to rotate an array (length 3) of integers in left direction.

            int[] nums = { 1, 2, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));

            /*int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 8, 8, 9 };;
            Array.Reverse(nums);
            foreach (var item in nums)
            {
                Console.Write(" " + item);
            }*/

            Console.ReadKey();
        }
    }
}
