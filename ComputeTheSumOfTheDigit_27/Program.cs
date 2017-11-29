using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeTheSumOfTheDigit_27
{
    class Program
    {
        static void Main(string[] args)
        {
            // №27 Write a C# program and compute the sum of the digits of an integer
            int s, sum = 0;

            Console.WriteLine("Enter a number: ");
            s = int.Parse(Console.ReadLine());

            while (s != 0)
            {
                sum += s % 10;
                s /= 10;
            }

            Console.WriteLine("Sum of the digit of the integer is: " + sum);
            Console.ReadLine();
        }
    }
}
