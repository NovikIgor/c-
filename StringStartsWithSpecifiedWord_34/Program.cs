using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStartsWithSpecifiedWord_34
{
    class Program
    {
        static void Main(string[] args)
        {
            // №34 Write a C# program to check if a string starts with a specified word. Go to the editor
            //Note: Suppose the sentence starts with "Hello"

            string sent1, sent2 = "Hello";

            Console.WriteLine("Let's start: ");
            sent1 = Console.ReadLine();

            //Console.WriteLine(sent1.Substring(0, 5) == "Hello");
            //Console.ReadKey();

            if (/*(sent1.Length < 6 && sent1.Equals(sent2)) || */(sent1.StartsWith(sent2)))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("Specified word not found");
            }
            Console.ReadLine();
        }
    }
}
