using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalc = true;

            while (continueCalc)
            {
                Console.WriteLine("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"Result: {result}");
                }

                Console.WriteLine("Do you want to perform another calculation? (yes/no): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                {
                    continueCalc = false;
                }
            }

            Console.WriteLine("Thank you for using the calculator!");
        }
    }
}
