using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 + num2;

        Console.WriteLine($"The sum of the numbers: {sum}");

        Console.ReadLine();
    }
}
