using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1 = 0, num2;
        char op;
        Console.Write("Please enter the first integer: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        for (; ;){
            Console.WriteLine("To stop the code type 'e'. ");
            Console.Write("Please enter an operand (+, -, *, /, ^): ");
            op = Convert.ToChar(Console.ReadLine());
            if(op == '+')
            {
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                num1 = num1 + num2;
                Console.WriteLine("Result: {0}", num1);
            }else if (op == '-')
            {
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                num1 = num1 - num2;
                Console.WriteLine("Result: {0}", num1);
            }else if (op == '*')
            {
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                num1 = num1 * num2;
                Console.WriteLine("Result: {0}", num1);
            }else if (op == '/')
            {
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    Console.WriteLine("Current output: {0}", num1);
                }
                else
                {
                    num1 = num1 / num2;
                    Console.WriteLine("Result: {0}", num1);
                }
            }
            else if (op == '^')
            {
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                num1 = (int)Math.Pow(num1, num2);
                Console.WriteLine("Result: {0}", num1);
            }else if(op == 'e')
            {
                Console.WriteLine("The code ENDED. ");
                return;
            }
        }
    }
}