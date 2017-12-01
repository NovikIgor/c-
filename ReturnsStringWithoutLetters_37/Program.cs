using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnsStringWithoutLetters_37
{
    class Program
    {
        static void Main(string[] args)
        {
            // №37 Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".

            string str = "PHP Tutorial";

            Console.WriteLine("Enter the text - {0}", str);
            string str2 = Console.ReadLine();

            Console.WriteLine("You enter - {0}", str2);

            if (str2.Substring(1, 2).Equals("HP"))
            {
                Console.WriteLine(str2.Remove(1, 2));
            }
            else
            {
                Console.WriteLine("Wrong words - {0}", str2);
            }

            //Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
            Console.ReadLine();
        }
    }
}