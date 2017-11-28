using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDeclarationsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*First5Tasks task_1 = new First5Tasks();
            task_1.First();*/

            /*First5Tasks task_2 = new First5Tasks();
            task_2.Second();*/

            /*First5Tasks task_3 = new First5Tasks();
            task_3.Third();*/

            /*First5Tasks task_4 = new First5Tasks();
            task_4.Four();*/

            /*First5Tasks task_5 = new First5Tasks();
            task_5.Five();*/

            //MultiplicationOf3nums();
            //MathThings();
            //FirstLoop();
            //FourNumbers();
            //ThreeNums();
            //LookOlder();
            //NumberFourTimesInRow();
            //Rectangle3Columns5rows();
            //ConverToKelvinAndFahrenheit();
            //RemoveSpecifiedCharacter();
            //LettersChandgePosition();
            //AddFirstLetterAtFrontAndBack();
            //ReturnTrueOrfalseInt();
            //ComputeTheSumOf2Int();
            //GetAbsoluteValue1();
            //ReturnTrueIfSomeIntIs20orSumIs20();
            //CheckInt1();
            //ConvertToLowercase();
            //FindTheLongestWord();
            //OddNums0_99();
        }

        class First5Tasks
        {

            public void First()
            {
                // №1 Write a C# Sharp program to print Hello and your name in a separate line.
                Console.Write("Hello! ");
                Console.WriteLine("Test-west)");
                Console.ReadLine();
            }

            public void Second()
            {
                // №2 Write a C# Sharp program to print the sum of two numbers.
                int s = 5, v = 10, d = s + v;

                Console.WriteLine(d);
                Console.ReadLine();
            }

            public void Third()
            {
                // №3 Write a C# Sharp program to print the result of dividing two numbers.
                int num1 = 1000, num2 = 5, res = num1 / num2;

                Console.WriteLine(res);
                Console.ReadLine();
            }

            public void Four()
            {
                // №4 Write a C# Sharp program to print the result of the specified operations.
                Console.WriteLine(-1 + 4 * 6);
                Console.WriteLine((35 + 5) % 7);
                Console.WriteLine(14 + -4 * 6 / 11);
                Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
                Console.ReadLine();
            }

            public void Five()
            {
                // №5 Write a C# Sharp program to swap two numbers.
                int num3, num4, num5;

                Console.WriteLine("Enter first number: ");
                num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                num4 = int.Parse(Console.ReadLine());

                num5 = num3;
                num3 = num4;
                num4 = num5;

                Console.WriteLine($"After swapping: \n First number  is {num3}\n Seconf number is {num4}");
                Console.ReadLine();
            }
        }

        static void MultiplicationOf3nums()
        {
            // №6 Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            int num6, num7, num8, result;

            Console.WriteLine("Enter first number: ");
            num6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            num8 = int.Parse(Console.ReadLine());

            result = num6 * num7 * num8;
            Console.WriteLine("The result of {0} x {1} x {2} = {3}", num6, num7, num8, result);
            Console.ReadLine();
        }

        static void MathThings()
        {
            // №7 Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            int num9, num10, resultAdding, resultSubtracting, resultMultiplying, resultDividing;

            Console.WriteLine("Enter first number: ");
            num9 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num10 = int.Parse(Console.ReadLine());

            resultAdding = num9 + num10;
            Console.WriteLine($"The adding of {num9} and {num10} = {resultAdding}");
            resultSubtracting = num9 - num10;
            Console.WriteLine($"The subtracting of {num9} and {num10} = {resultSubtracting}");
            resultMultiplying = num9 * num10;
            Console.WriteLine($"The multiplying of {num9} and {num10} = {resultMultiplying}");
            resultDividing = num9 / num10;
            Console.WriteLine($"The dividing of {num9} and {num10} = {resultDividing}");
            Console.WriteLine("{0} mod {1} = {2}", num9, num10, num9 % num10);
            Console.ReadLine();
        }

        static void FirstLoop()
        {
            // №8 Write a C# Sharp program that takes a number as input and print its multiplication table.
            int num11, i, result1;

            Console.WriteLine("Enter a number: ");
            num11 = int.Parse(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                result1 = num11 * i;
                Console.WriteLine($"{num11} * {i} = {result1}");
            }
            Console.ReadLine();
        }

        static void FourNumbers()
        {
            // №9 Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            int num12, num13, num14, num15, average;

            Console.WriteLine("Enter the First number: ");
            num12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            num13 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number: ");
            num14 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Four number: ");
            num15 = int.Parse(Console.ReadLine());

            average = (num12 + num13 + num14 + num15) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4}", num12, num13, num14, num15, average);
            Console.ReadLine();
        }

        static void ThreeNums()
        {
            // №10 Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            int num16, num17, num18, result, result2;

            Console.WriteLine("Enter three numbers (x,y,z)");
            Console.WriteLine("Enter first: ");
            num16 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second: ");
            num17 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third: ");
            num18 = int.Parse(Console.ReadLine());

            result = (num16 + num17) * num18;
            result2 = (num16 * num17) + (num17 * num18);

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z  is {3}\n", num16, num17, num18, result);
            Console.WriteLine($"and x.y + y.z is {result2}");
            Console.ReadLine();
        }

        static void LookOlder()
        {
            // №11 Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
            int age;
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} years", age);
            Console.ReadLine();
        }

        static void NumberFourTimesInRow()
        {
            // №12 Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
            int num1;
            Console.Write("Enter a digit: ");
            num1 = int.Parse(Console.ReadLine());

            // Part a:
            Console.Write(num1);
            Console.Write(" ");
            Console.Write(num1);
            Console.Write(" ");
            Console.Write(num1);
            Console.Write(" ");
            Console.Write(num1);
            Console.WriteLine();

            Console.Write(num1);
            Console.Write(num1);
            Console.Write(num1);
            Console.WriteLine(num1);
            Console.WriteLine();

            // Part b:
            Console.WriteLine("{0} {0} {0} {0}", num1);
            Console.WriteLine("{0}{0}{0}{0}", num1);

            Console.ReadLine();
        }

        static void Rectangle3Columns5rows()
        {
            // №13 Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
            int number;
            Console.Write("Enter a digit: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{number}{number}{number}");
                if (i == 0)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        Console.WriteLine($"{number} {number}");
                    }
                }
            }
            Console.ReadKey();
        }

        static void ConverToKelvinAndFahrenheit()
        {
            // № 14 Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            int celsius, kelvin;
            double fahrenheit;

            Console.Write("Enter the amount of celsius: ");
            celsius = int.Parse(Console.ReadLine());

            if (celsius != 0)
            {
                kelvin = celsius + 273;
                Console.WriteLine("Kelvin = {0}", kelvin);

                fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"Fahrenheit = {fahrenheit}");
            }
            else
            {
                Console.Write("Enter the number more than {0}", celsius);
            }
            Console.ReadKey();
        }

        static void RemoveSpecifiedCharacter()
        {
            // №15 Write a C# program remove specified a character from a non-empty string using index of a character.
            string str;

            Console.WriteLine("Let's start: ");
            str = Console.ReadLine();

            if (str.Length >= 5)
            {
                Console.WriteLine(str.Remove(1, 1));
                Console.WriteLine(str.Remove(5, 1));
                Console.WriteLine(str.Remove(0, 1));
            }
            else
            {
                Console.WriteLine("Too short! ");
            }
            Console.ReadKey();
        }

        static void LettersChandgePosition()
        {
            // №16 Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            string str, str1;

            Console.WriteLine("Let's start: ");
            str = Console.ReadLine();
            Console.WriteLine("And again: ");
            str1 = Console.ReadLine();

            Console.WriteLine(first_last(str));
            Console.WriteLine(first_last(str1));
            Console.ReadKey();
        }
        public static string first_last(string ustr)
        {
            // code that I don't understand
            return ustr.Length > 1
            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }

        static void AddFirstLetterAtFrontAndBack()
        {
            // №17 Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
            string s, s2;

            Console.WriteLine("Enter a sentence: ");
            s = Console.ReadLine();

            s2 = s.Substring(0, 1);
            Console.WriteLine(s2 + s + s2);
            Console.ReadKey();
        }

        static void ReturnTrueOrfalseInt()
        {
            // №18 Write a C# program to check two given integers and return true if one is negative and one is positive.
            int num1, num2;
            bool tr = true, fl = false;

            Console.Write("Enter a some first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a some second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive: ");
            if (num1 > 0 && num2 > 0)
            {
                Console.WriteLine("Both are Positive intergers, so {0}", fl);
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("Both are negative intergers, so {0}", fl);
            }
            else
            {
                Console.WriteLine(tr);
            }
            Console.ReadKey();
        }

        static void ComputeTheSumOf2Int()
        {
            // № 19 Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            int num1, num2, res;

            Console.Write("Enter a some first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a some second number: ");
            num2 = int.Parse(Console.ReadLine());


            if (num1.Equals(num2))
            {
                res = (num1 + num2) * 3;
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine(num1 + num2);
            }
            Console.ReadKey();
        }

        static void GetAbsoluteValue1()
        {
            // №20 Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
            int result, result1, num1, num2;

            Console.Write("Enter a some first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a some second number: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1 - num2;
            result1 = (num1 - num2) * 2;

            if (num1 > num2)
            {
                result *= -1;
                Console.WriteLine($"The double difference between: {num1} and {num2} is {result1}");
            }
            else
            {
                Console.WriteLine("The difference between: {0} and {1} is {2}", num1, num2, result);
            }
            Console.ReadKey();
        }

        static void ReturnTrueIfSomeIntIs20orSumIs20()
        {
            // №21 Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            int result, num1, num2;
            bool tr = true;

            Console.Write("Enter a some first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a some second number: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1 + num2;

            if (result == 20 || num1 == 20 || num2 == 20)
            {
                Console.WriteLine($"Of course it's {tr}, because some number = 2");
            }
            Console.WriteLine("Try again!");
            Console.ReadKey();
        }

        static void CheckInt1()
        {
            // №22 Write a C# program to check if an given integer is within 20 of 100 or 200
            Console.WriteLine("Give me a number.");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{result(number)}");
            Console.ReadKey();
        }

        public static bool result(int num)
        {
            if (Math.Abs(num - 100) <= 10 || Math.Abs(num - 200) <= 10)
            {
                return true;
            }
            else { return false; }

        }

        static void ConvertToLowercase()
        {
            // №23 Write a C# program to convert a given string into lowercase.
            string str = "The quick BROWN fox jumps OVER THE lazy dog.";

            Console.WriteLine("Original is: {0}\n", str);
            Console.WriteLine(str.ToLower());
            Console.ReadKey();
        }

        static void FindTheLongestWord()
        {
            // Wrong solution !
            // №24 Write a C# program to find the longest word in a string.                                                  
            string[] words = { "cherry", "apple", "blueberry" };

            int longestLength = words.Max(w => w.Length);
            Console.WriteLine("The longest word is {0}, {1} characters long.", words[2], longestLength);
            Console.ReadKey();
        }

        static void OddNums0_99()
        {
            // №25 Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            int nums = 0;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            Console.ResetColor();

            for (int i = nums; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
