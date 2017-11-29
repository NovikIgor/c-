using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConvertHexadecimalNumberToDecimal_30
{
    class Program
    {
        static void Main(string[] args)
        {
            // №30 Write a C# program to convert a hexadecimal number to decimal number.

            string hexval = "4B0";
            Console.WriteLine("Hexadecimal number: " + hexval);
            int decValue = int.Parse(hexval, NumberStyles.HexNumber);
            Console.WriteLine("Convert to decimal number: " + decValue);
            Console.ReadLine();
        }
    }
}
