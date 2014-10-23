using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        private static int result;
        private static int firstNumber;
        private static int secondNumber;
        private static string input;

        static void Main(string[] args)
        {
            do
            {

            result = 0;
            // Print Menu
            PrintMenu();

            // Select options
            Console.Write("\nChoice:");
            var choice = Console.ReadLine();
           
            // Take different actions based on the choice the user did and calculate
            Calculate(choice);

            // Print the result to the screen
            Console.Write("Result:{0}\n",result);
            
            Console.Write("\nDo you want to make another calculation? (y/n)");
            input=Console.ReadLine();

            } while (input=="y"||input=="Y");
            

        }

        private static void Calculate(string choice="A")
        {
            switch (choice)
            {
                case "a":
                case "A":
                    UserInputNumbers();
                    Addition(firstNumber, secondNumber);
                    break;
                case "b":
                case "B":
                    UserInputNumbers();
                    Subtraction(firstNumber, secondNumber);
                    break;
                case "c":
                case "C":
                    UserInputNumbers();
                    Multiplication(firstNumber, secondNumber);
                    break;
                case "d":
                case "D":
                    UserInputNumbers();
                    if (secondNumber!=0)
                    {
                        Division(firstNumber, secondNumber); 
                    }
                    else
                    {
                        Console.WriteLine("Divided by zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select A, B, C or D.");
                    break;
            }
        }

        private static void UserInputNumbers()
        {
            Console.Write("Enter the first number:");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number:");
            secondNumber = int.Parse(Console.ReadLine());
        }

        private static void Division(int firstNumber, int secondNumber)
        {
            result = firstNumber/secondNumber;
        }

        private static void Multiplication(int firstNumber, int secondNumber)
        {
            result = firstNumber*secondNumber;
        }

        private static void Subtraction(int firstNumber, int secondNumber)
        {
            result = firstNumber-secondNumber;
        }

        private static void Addition(int firstNumber,int secondNumber)
        {
            result = firstNumber + secondNumber;
        }

        private static void PrintMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Select an operator");
            stringBuilder.Append("\n------------------");
            stringBuilder.Append("\nA. Addition (+)");
            stringBuilder.Append("\nB. Subtraction (-)");
            stringBuilder.Append("\nC. Multiplication (*)");
            stringBuilder.Append("\nD. Division (/)");

            Console.WriteLine(stringBuilder);

        }
    }
}
