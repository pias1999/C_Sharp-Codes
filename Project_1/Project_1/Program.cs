using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double num1 = 0, num2;
        string op;
        Console.WriteLine("\t\t\t\t\t\t*****CALCULATOR*****");
        Console.WriteLine("\t\t\t\t****You can perform the following operations here.****");
        Console.WriteLine("\t\t\t***ADDITION, SUBTRACTION, MULTIPLICATION, DIVISION, POWER, SQUARE ROOT.***");
        Console.WriteLine("\t\t***SIN, COS, TAN, ASIN, ACOS, ATAN, LOG, LOG2, LOG10, EXPONENTIAL, AND ABSOLUTE VALUE.***");
        start: Console.Write("\nPlease enter the first value: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        for (; ;)
        {
            Console.WriteLine("\nTo stop the code type 'e'. ");
            Console.WriteLine("To start the code from the beginning type 'clr'. ");
            Console.Write("Please enter an operand (+, -, *, /, ^, sqrt, sin, cos, tan, asin, acos, atan, log, log2, log10, exp, abs): ");
            op = Convert.ToString(Console.ReadLine());
            if (op == "+")
            {
                Console.Write("Please enter the next value: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                num1 = num1 + num2;
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "-")
            {
                Console.Write("Please enter the next value: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                num1 = num1 - num2;
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "*")
            {
                Console.Write("Please enter the next value: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                num1 = num1 * num2;
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "/")
            {
                Console.Write("Please enter the next value: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("\nCannot divide by zero.");
                    Console.WriteLine("Current output: {0}", num1);
                }
                else
                {
                    num1 = num1 / num2;
                    Console.WriteLine("\nResult: {0}", num1);
                }
            }
            else if (op == "^")
            {
                Console.Write("Please enter the next value: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                num1 = (int)Math.Pow(num1, num2);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "sin")
            {
                num1 = Math.Sin(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "cos")
            {
                num1 = Math.Cos(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "tan")
            {
                num1 = Math.Tan(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "asin")
            {
                num1 = Math.Asin(num1);
                Console.WriteLine("\nResult: {0}", (num1 * 180 / Math.PI));
            }
            else if (op == "acos")
            {
                num1 = Math.Acos(num1);
                Console.WriteLine("\nResult: {0}", (num1 * 180 / Math.PI));
            }
            else if (op == "atan")
            {
                num1 = Math.Atan(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "sqrt")
            {
                num1 = Math.Sqrt(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "log")
            {
                num1 = Math.Log(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "log2")
            {
                num1 = Math.Log2(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "log10")
            {
                num1 = Math.Log10(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "exp")
            {
                num1 = Math.Exp(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "abs")
            {
                num1 = Math.Abs(num1);
                Console.WriteLine("\nResult: {0}", num1);
            }
            else if (op == "clr")
            {
                goto start;
            }
            else if (op == "e")
            {
                Console.WriteLine("\n\t\t\t\t\t\tThe code ENDED.");
                return;
            }
        }
    }
}