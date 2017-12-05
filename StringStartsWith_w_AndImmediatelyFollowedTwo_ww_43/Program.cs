using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStartsWith_w_AndImmediatelyFollowedTwo_ww_43
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 43 Write a C# program to check if a given string starts with "w" and immediately followed by two "ww".

            string input, letter1 = "w", letter2 = "W";

            Console.WriteLine("Let's start: ");
            input = Console.ReadLine();

            if (input.StartsWith(letter1) || input.StartsWith(letter2))
            {
                Console.WriteLine(letter1 + input.ToLower());
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
    }
}
