using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckGivenPositiveNumIsMultiple3Or7_33
{
    class Program
    {
        static void Main(string[] args)
        {
            // №33 Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.

            int num1;

            Console.WriteLine("Enter your favorite number: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 3 == 0 || num1 % 7 == 0) //If I choose "/" not "%", it's not good, why?
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine("Your number {0} is not multiple 3 or 7", num1);
            }
            Console.ReadLine();
        }
    }
}
