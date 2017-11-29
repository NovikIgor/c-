using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheWordsInSentence_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // №28 Write a C# program to reverse the words of a sentence.

            string firstSentence, reversed;
            
            Console.WriteLine("Give me a sentence: ");
            firstSentence = Console.ReadLine();
            reversed = string.Join(", ", firstSentence.Split(' ').Reverse());

            Console.WriteLine("The reverse is: \n" + reversed);
            Console.ReadLine();
        }
    }
}
