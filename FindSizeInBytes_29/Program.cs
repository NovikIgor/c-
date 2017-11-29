using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindSizeInBytes_29
{
    class Program
    {
        static void Main(string[] args)
        {
            // №29 Write a C# program to find the size of a specified file in bytes.

            Console.WriteLine(@"Enter a filename with full path(ie: C:\Windows\regedit.exe): ");
            var input = Console.ReadLine();

            if (File.Exists(input))
            {
                FileInfo fileSize = new FileInfo(input);
                long fullSize = fileSize.Length;
                Console.WriteLine("The size of {0} is {1} bytes.", input, fullSize);
            }
            else
            { 
                Console.WriteLine("File does not exist or path not correct. Please try again.");
            }
        Console.ReadLine();
        }
    }
}
