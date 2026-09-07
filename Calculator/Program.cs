namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter operation (+, -, *, /): ");
                string? operation = Console.ReadLine()!;

                double result ;

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
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }

                        result = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (y/n): ");
                string? answer = Console.ReadLine();

                if (answer?.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
