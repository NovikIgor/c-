using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTwoGivenNumbers_35
{
    class Program
    {
        static void Main(string[] args)
        {
            // №35 Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.

            int num1, num2;

            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < 100 && num2 > 200)
            {
                Console.WriteLine(true);
                Console.WriteLine($"First number {num1} is < 100 and second number {num2} is > 200");
            }
            else
            {
                Console.WriteLine("This is not a mistake, just does not coincide with the requirement of the task :)");
            }
            Console.ReadLine();
        }
    }
}
