using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsOddNumber_53
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 53 Write a C# program to check if an array contains an odd number.

            Console.WriteLine("Enter your integer array length: ");
            int s = int.Parse(Console.ReadLine());
            int[] array = new int[s];

            int i = 0;
            while (i < s)
            {
                Console.WriteLine("Enter element for array: ");
                // Enter elements for array from keyboard and fill them with an array
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            // Outputting the contents of an array
            for (i = 0; i < s; i = i + 1)
                Console.WriteLine("Element [" + i + "]: " + array[i]);
            
            Console.WriteLine("\nCheck if an array contains an odd number? - " + even_odd(array));
            Console.ReadKey();
        }

        public static bool even_odd(int[] array)
        {
            foreach (var n in array)
            {
                if (n % 2 != 0)
                    return true;
            }
            return false;

        }
    }
}
