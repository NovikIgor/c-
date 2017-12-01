using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLargestAndLowestValuesFromThreeInt_39
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 39 Write a C# program to find the largest and lowest values from three integer values.

            int num1, num2, num3;

            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 && num1 == num3)
            {
                Console.WriteLine("All numbers are equal!");
            }
            else
            {
                // The largest
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine($"Largest of three: {num1}");
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"Largest of three: {num2}");
                }
                else
                {
                    Console.WriteLine($"Largest of three: {num3}");
                }

                // The lowest
                if (num1 < num2 && num1 < num3)
                {
                    Console.WriteLine($"Lowest of three: {num1}");
                }
                else if (num2 < num1 && num2 < num3)
                {
                    Console.WriteLine($"Lowest of three: {num2}");
                }
                else
                {
                    Console.WriteLine($"Lowest of three: {num3}");
                }
            }

            //Console.WriteLine("Largest of three: " + Math.Max(num1, Math.Max(num2, num3)));
            //Console.WriteLine("Lowest of three: " + Math.Min(num1, Math.Min(num2, num3)));

            Console.Read();
        }
    }
}
