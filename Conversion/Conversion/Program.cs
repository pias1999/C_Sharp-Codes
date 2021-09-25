using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double num1, num2;

        Console.Write("Enter first value: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter first value: ");
        num2 = double.Parse(Console.ReadLine());
        num1 = Convert.ToInt32(num1);
        num2 = Convert.ToInt32(num2);
        int sum = (int)(num1 + num2);
        Console.WriteLine("Num1 = {0}, Num2 = {1}\nSum = {0} + {1} = {2}", num1, num2, sum);
    }
}