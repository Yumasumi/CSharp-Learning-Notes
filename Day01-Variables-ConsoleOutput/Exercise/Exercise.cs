using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void SimpleCalculator()
        {
            // TODO: Implement the calculator logic here
            Console.WriteLine("Enter the first number:");
            string userInput1 = Console.ReadLine();
            int firstNumber;
            int.TryParse(userInput1, out firstNumber);
            
            Console.WriteLine("Enter the second number:");
            string userInput2 = Console.ReadLine();
            int secondNumber;
            int.TryParse(userInput2, out secondNumber);
            
            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();
            
            int result = 0; 
            
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"Result: {result}");
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
                Console.WriteLine($"Result: {result}");
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine($"Result: {result}");
            }
            else if (operation == "/")
            {
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            }
        }
    }
}
