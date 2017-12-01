using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTheNearestValue20TwoGivenIntegers_40
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 40 Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.

            int mainNum = 50, num1, num2, s, x;

            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            s = Math.Abs(num1 - mainNum);
            x = Math.Abs(num2 - mainNum);

            Console.WriteLine(s == x ? 0 : (s < x ? num1 : num2));
            Console.Read();
        }
    }
}
