using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            
            Console.WriteLine("Please enter an operator: (*/+-)");
            string inputOp = Console.ReadLine();
            
            Console.WriteLine("Enter your first number:");
            int number1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your second number:");
            int number2 = int.Parse(Console.ReadLine());

            switch (inputOp)
            {
                case "*":
                    Console.WriteLine("The product of these two numbers is " + (number1 * number2));
                    break;
                case "/":
                    Console.WriteLine("First number divided by Second Number is " + (number1 / number2));
                    break;
                case "+":
                    Console.WriteLine("The sum of these two numbers is " + (number1 + number2));
                    break;
                case "-":
                    Console.WriteLine("First Number minus Second Number is " + (number1 - number2));
                    break;
                default:
                    Console.WriteLine("Sorry, I think you fucked up...");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}