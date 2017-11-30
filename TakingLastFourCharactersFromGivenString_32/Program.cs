using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakingLastFourCharactersFromGivenString_32
{
    class Program
    {
        static void Main(string[] args)
        {
            // №32 Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one.

            string test, copy;

            Console.WriteLine("Enter your sentence here: ");
            test = Console.ReadLine();
            Console.WriteLine($"Your sentence have {test.Length} symbols!");

            if (test.Length < 4)
            {
                Console.WriteLine(test + test + test + test);
            }
            else
            {
                copy = test.Substring(test.Length - 4);
                Console.WriteLine(copy + copy + copy + copy);
            }

            Console.ReadLine();

            // What is in writeLine ?
            /*if (str.Length > 4)
            {
                Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            }*/

        }
    }
}