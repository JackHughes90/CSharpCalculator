using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            
            Console.WriteLine("Please enter an operator: (*/+-) ");
            string inputOp = Console.ReadLine();
            
            Console.WriteLine("How many numbers do you want to " + inputOp + "? ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            for (int index = 0; index < count; index++)
            {
                Console.Write("Please enter number " + (index + 1) + ": ");
                numbers[index] = int.Parse(Console.ReadLine());
            }

            int answer = numbers[0];

            for (int index = 1; index < count; index++)
            {
                switch (inputOp)
                {
                    case "*":
                        answer *= numbers[index];
                        break;
                    case "/":
                        answer /= numbers[index];
                        break;
                    case "+":
                        answer += numbers[index];
                        break;
                    case "-":
                        answer -= numbers[index];
                        break;
                    default:
                        Console.WriteLine("Sorry, I think you fucked up...");
                        break;
                }
            }
            
            Console.WriteLine("The answer is: " + answer);

            /*
            This is part of an old build, which only took 2 numbers and performed an operation on them...
            
            Console.WriteLine("Enter your first number:");
            int number1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your second number:");
            int number2 = int.Parse(Console.ReadLine());

            
            */
            
            Console.ReadLine();
        }
    }
}