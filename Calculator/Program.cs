using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Enter a number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of these two numbers is " + (number1 + number2));
            Console.ReadLine();
        }
    }
}