using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First4CharIsLowerCase_42
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 42 Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case.

            string input;

            Console.WriteLine("Enter your sentence: ");
            input = Console.ReadLine();

            if (input.Length < 4)
            {
                Console.WriteLine(input.ToUpper());
            }
            else
            { 
                Console.WriteLine(input.Substring(0, 4).ToLower() + input.Substring(4, input.Length - 4));
            }
            Console.Read();
        }
    }
}
