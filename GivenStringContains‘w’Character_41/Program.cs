using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenStringContains_w_Character_41
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 41 Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.

            string input;
            int count = 0;

            Console.WriteLine("Enter the sentence with 'w' letter: ");
            input = Console.ReadLine();

            Console.WriteLine("You enter - {0}", input);

            foreach (char item in input)
            {
                if (item == 'w')
                {
                    count++;
                }
            }
            Console.WriteLine("Number of 'w' charapter is: {0}", count);
            Console.Read();
        }
    }
}
