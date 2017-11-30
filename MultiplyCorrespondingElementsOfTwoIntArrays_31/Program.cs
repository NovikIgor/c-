using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyCorrespondingElementsOfTwoIntArrays_31
{
    class Program
    {
        static void Main(string[] args)
        {
            // №31 Write a C# program to multiply corresponding elements of two arrays of integers.

            int[] arr1 = new int[5] {1, 12, 10, 4, 54};
            int[] arr2 = {3, 10, 17, 24, 4};

            Console.WriteLine("{0}", string.Join(", ", arr1));
            Console.WriteLine("{0}", string.Join(", ", arr2));

            Console.WriteLine("This is our equal arrays:\t {0} elements, {1} elements.", arr1.Length, arr2.Length);
            Console.WriteLine("After multiply: ");

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] * arr2[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
