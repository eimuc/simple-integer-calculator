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

			while (true)
			{
				DisplayList();

				command = Console.ReadLine();
				if (command == "exit")
				{
					break;
				}

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
					if (b != 0)
					{
						DisplayResult(a / b);
					}
					else
					{
						Console.WriteLine("Division by Zero!");
					}

				}
				else if (operation == "%")
				{
					DisplayResult(a % b);
				}
			}
		}

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