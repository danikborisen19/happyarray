namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;
            while (continueCalculation)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");
                string input = Console.ReadLine();
                int choice = int.Parse(input);
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Result: {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {num1 * num2}");
                        break;
                    case 4:
                        if (num2 != 0) Console.WriteLine($"Result: {num1 / num2}");
                        else Console.WriteLine("Error : Division by zero is not allowed");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose a number between 1-4.");
                        break;
                }
                Console.WriteLine("\nDo you want to perform another calculation? (y/n): ");
                string continueInput = Console.ReadLine();
                continueCalculation = continueInput.ToLower() == "y";
            }
        }
    }
}