using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStringEveryOtherCharacterFromFirstPos_44
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 44 Write a C# program to create a new string of every other character (odd position) from the first position of a given string.
            // Input a string : w3resource
            // wrsuc

            var num = string.Empty;
            string input;

            Console.WriteLine("Input new sentence: ");
            input = Console.ReadLine();
           
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0) num += input[i];
            }
            Console.WriteLine(num);

            // Bad solution
            //Console.WriteLine(input.Substring(1,1) + input.Substring(3, 1) + input.Substring(5, 1) + input.Substring(7, 1) + input.Substring(9, 1) + input.Substring(11, 1));

            Console.ReadLine();
        }
    }
}
