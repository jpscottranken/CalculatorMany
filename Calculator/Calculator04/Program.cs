using System;
using static System.Console;

//  Version04:
//  All variables local to Main()
//  Variable passing02 - out parameters

namespace Calculator04
{
    internal class Program
    {
        static string resultQuot = "";
        static string resultMod = "";

        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int sum = 0;
            int diff = 0;
            int prod = 0;
            decimal quot = 0m;
            int mod = 0;

            while (1 == 1)
            {
                Clear();
                InputNumber1(out num1);
                WriteLine($"The value of num1 is:\t{num1}");
                InputNumber2(out num2);
                WriteLine($"The value of num2 is:\t{num2}");
                CalculateSum(num1, num2, out sum);
                CalculateDiff(num1, num2, out diff);
                CalculateProd(num1, num2, out prod);
                CalculateQuot(num1, num2, out quot);
                CalculateMod(num1, num2, out mod);
                ShowResults(num1, num2, sum, diff, prod, quot, mod);
            }
        }

        static void InputNumber1(out int num1)
        {
            string numStr;
            bool result;
            int number;

            Write("Enter integer:\t\t");
            numStr = ReadLine();

            result = int.TryParse(numStr, out number);
            if (!result)
            {
                WriteLine("Illegal Input. Try Again.");
                ReadLine();
                InputNumber1(out num1);
            }
            else
            {
                num1 = number;
            }
        }

        static void InputNumber2(out int num2)
        {
            string numStr;
            bool result;
            int number;

            Write("Enter integer:\t\t");
            numStr = ReadLine();

            result = int.TryParse(numStr, out number);
            if (!result)
            {
                WriteLine("Illegal Input. Try Again.");
                ReadLine();
                InputNumber2(out num2);
            }
            else
            {
                num2 = number;
            }
        }
        static void CalculateSum(int num1, int num2, out int sum)
        {
            sum = num1 + num2;
        }

        static void CalculateDiff(int num1, int num2, out int diff)
        {
            diff = num1 - num2;
        }

        static void CalculateProd(int num1, int num2, out int prod)
        {
            prod = num1 * num2;
        }

        static void CalculateQuot(int n1, int n2, out decimal quot)
        {
            if (n2 == 0)
            {
                resultQuot = "Illegal Divide";
                quot = 0.0m;
                return;
            }

            quot = (decimal)n1 / (decimal)n2;
        }

        static void CalculateMod(int n1, int n2, out int mod)
        {
            if (n2 == 0)
            {
                resultMod = "Illegal Mod Divide";
                mod = 0;
                return;
            }

            mod = n1 % n2;
        }

        static void ShowResults(int n1, int n2,
                                int s, int d,
                                int p, decimal q, int m)
        {
            WriteLine($"\n\nYour Final Results:");
            WriteLine($"{n1} + {n2} = {s}");
            WriteLine($"{n1} - {n2} = {d}");
            WriteLine($"{n1} * {n1} = {p}");

            if (resultQuot.Trim() != "")
            {
                WriteLine($"{n1} / {n2} = {resultQuot}");
            }
            else
            {
                WriteLine($"{n1} / {n2} = {q:n2}");
            }

            if (resultMod.Trim() != "")
            {
                WriteLine($"{n1} / {n2} = {resultMod}");
            }
            else
            {
                WriteLine($"{n1} % {n2} = {m}");
            }

            ReadLine();
        }
    }
}
