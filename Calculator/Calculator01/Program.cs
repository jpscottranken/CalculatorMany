using System;
using static System.Console;

//  Version01:
//  All variables global (class variables)

namespace Calculator01
{
    internal class Program
    {
        static int num1;
        static int num2;
        static int sum;
        static int diff;
        static int prod;
        static decimal quot;
        static int mod;
        static string resultQuot = "";
        static string resultMod  = "";

        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Clear();
                InputNum1();
                InputNum2();
                CalculateSum();
                CalculateDiff();
                CalculateProd();
                CalculateQuot();
                CalculateMod();
                ShowResults();
            }
        }

        static void InputNum1()
        {
            string num1Str;
            bool result;

            Write("Enter integer1:\t\t");
            num1Str = ReadLine();

            result = int.TryParse(num1Str, out num1);
            if (!result)
            {
                WriteLine("Illegal Input. Try Again.");
                ReadLine();
                InputNum1();
            }
        }

        static void InputNum2()
        {
            string num2Str;
            bool result;

            Write("Enter integer2:\t\t");
            num2Str = ReadLine();

            result = int.TryParse(num2Str, out num2);
            if (!result)
            {
                WriteLine("Illegal Input. Try Again.");
                ReadLine();
                InputNum2();
            }
        }

        static void CalculateSum()
        {
            sum = num1 + num2;
        }

        static void CalculateDiff()
        {
            diff = num1 - num2;
        }

        static void CalculateProd()
        {
            prod = num1 * num2;
        }

        static void CalculateQuot()
        {
            if (num2 == 0)
            {
                resultQuot = "Illegal Divide";
                return;
            }

            quot = (decimal)num1 / (decimal)num2;
        }

        static void CalculateMod()
        {
            if (num2 == 0)
            {
                resultMod = "Illegal Mod Divide";
                return;
            }

            mod = num1 % num2;
        }

        static void ShowResults()
        {
            WriteLine($"\n\nYour Final Results:");
            WriteLine($"{num1} + {num2} = {sum}");
            WriteLine($"{num1} - {num2} = {diff}");
            WriteLine($"{num1} * {num2} = {prod}");

            if (resultQuot.Trim() != "")
            {
                WriteLine($"{num1} / {num2} = {resultQuot}");
            }
            else
            {
                WriteLine($"{num1} / {num2} = {quot:n2}");
            }

            if (resultMod.Trim() != "")
            {
                WriteLine($"{num1} / {num2} = {resultMod}");
            }
            else
            {
                WriteLine($"{num1} % {num2} = {mod}");
            }

            ReadLine();
        }
    }
}
