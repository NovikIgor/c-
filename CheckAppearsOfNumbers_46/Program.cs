using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAppearsOfNumbers_46
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 46 Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.

            int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 5 };
            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(arr.First() == input && arr.Length > 0 || arr.Last() == input && arr.Length > 0);
            Console.ReadKey();
        }
    }
}
