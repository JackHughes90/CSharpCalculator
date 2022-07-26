using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                PerformOneCalculation();
            }
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator!");
        }

        private static void PerformOneCalculation()
        {
            var inputOp = AskForOperator();
            
            Console.WriteLine($"How many numbers do you want to {inputOp}? ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            for (int index = 0; index < count; index++)
            {
                Console.Write($"Please enter number {index + 1}: ");
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
            
            Console.WriteLine($"The answer is: {answer}");
        }

        private static string AskForOperator()
        {
            Console.WriteLine("Please enter an operator: (*/+-) ");
            string inputOp = Console.ReadLine();
            return inputOp;
        }
    }
}