using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СheckIsIntegerisInTheRange_36
{
    class Program
    {
        static void Main(string[] args)
        {
            // №36 Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. 

            int num1, num2;

            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            if (((num1 >= -10 && num1 <= 10)) || ((num2 >= -10 && num2 <= 10)))
            {
                if (((num1 >= -10 && num1 <= 10)))
                {
                    Console.WriteLine($"First number {num1} is range -10 to 10");
                }
                else
                {
                    Console.WriteLine($"Second number {num2} is is range -10 to 10.");
                }
                    Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("This is not a mistake, just does not coincide with the requirement of the task :)");
            }
            Console.ReadLine();
        }
    }
}
