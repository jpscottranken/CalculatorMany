using System;
using static System.Console;

//  Version02:
//  All variables local to Main()
//  Variable passing01

namespace Calculator02
{
    internal class Program
    {
        static string resultQuot = "";
        static string resultMod = "";

        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Clear();
                int num1 = InputNumber(1);
                int num2 = InputNumber(2);
                int sum  = CalculateSum(num1, num2);
                int diff = CalculateDiff(num1, num2);
                int prod = CalculateProd(num1, num2);
                decimal quot = CalculateQuot(num1, num2);
                int mod  = CalculateMod(num1, num2);
                ShowResults(num1, num2, sum, diff, prod, quot, mod);
            }
        }

        static int InputNumber(int theNumber)
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
                if (theNumber == 1)
                {
                    InputNumber(1);
                }
                else if (theNumber == 2)
                {
                    InputNumber(2);
                }
            }

            return number;
        }

        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int CalculateDiff(int num1, int num2)
        {
            return num1 - num2;
        }

        static int CalculateProd(int num1, int num2)
        {
            return num1 * num2;
        }

        static decimal CalculateQuot(int n1, int n2)
        {
            if (n2 == 0)
            {
                resultQuot = "Illegal Divide";
                return 0.0m;
            }

            return (decimal)n1 / (decimal)n2;
        }

        static int CalculateMod(int n1, int n2)
        {
            if (n2 == 0)
            {
                resultMod = "Illegal Mod Divide";
                return 0;
            }

            return n1 % n2;
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
