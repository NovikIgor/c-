using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheLargestValueInArray_51
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 51 Write a C# program to get the larger value between first and last element of an array (length 3) of integers.

            int[] nums = { 1, 4, 15, 6, 7, 8, 3 };
            Console.WriteLine("Your array: [{0}]", string.Join(", ", nums));

            var h_val = nums[0];
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[0])
                    h_val = nums[i];
            }

            Console.Write("The largest numbers in array is: {0}", h_val);
            //Console.WriteLine(nums.Max());
            Console.ReadKey();
        }
    }
}
