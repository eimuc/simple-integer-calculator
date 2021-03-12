using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string command, operation;
            string[] parameters;

            do
            {
                try
                {

                    DisplayList();

                    command = Console.ReadLine();
                    if (command == "exit") break;

                    parameters = command.Split(" ");
                    a = Int32.Parse(parameters[0]);
                    b = Int32.Parse(parameters[2]);
                    operation = parameters[1];

                    if (operation == "+")
                    {
                        DisplayResult(a + b);
                    }
                    else if (operation == "-")
                    {
                        DisplayResult(a - b);
                    }
                    else if (operation == "*")
                    {
                        DisplayResult(a * b);
                    }
                    else if (operation == "/")
                    {

                        DisplayResult(a / b);

                    }
                    else if (operation == "%")
                    {
                        DisplayResult(a % b);
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Wrong input!");
                }
            } while (true);

            static void DisplayList()
            {
                Console.WriteLine("");
                Console.WriteLine("========================================");
                Console.WriteLine("Calculator");
                Console.WriteLine("========================================");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Enter your command:");
                Console.WriteLine("");
                Console.WriteLine("number + number");
                Console.WriteLine("number - number");
                Console.WriteLine("number * number");
                Console.WriteLine("number / number");
                Console.WriteLine("number % number");
                Console.WriteLine("");
                Console.WriteLine("exit");
                Console.WriteLine("========================================");
                Console.WriteLine("");
            }

            static void DisplayResult(int result)
            {
                Console.WriteLine($"result: {result}");
            }
        }

    }
}