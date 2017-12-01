using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNewStringOfTwoCharactersFromGivenString_38
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 38 Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH".

            string str1 = "PHP Tutorial";
            string result = "";

            if (str1.Length >= 1 && str1[0] == 'P')
            {
                result += str1[0];
            }
            if (str1.Length >= 2 && str1[1] == 'H')
            { 
                result += str1[1];
            }

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
