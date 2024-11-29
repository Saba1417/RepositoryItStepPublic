public class Calculator
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.");
    public double Modulus(double a, double b) => a % b;
}

public delegate double CalculatorDelegate(double a, double b);

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        bool continueCalculations = true;
        double previousResult = 0;
        bool isFirstCalculation = true;

        while (continueCalculations)
        {
            double a, b;

            if (isFirstCalculation)
            {
                Console.WriteLine("Enter the first number:");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                isFirstCalculation = false;
            }
            else
            {
                a = previousResult;
                Console.WriteLine($"Using previous result: {a}");
            }

            Console.WriteLine("Enter the second number:");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Now enter operation symbol (+, -, *, /, %):");
            string operationSymbol = Console.ReadLine();

            CalculatorDelegate operation = operationSymbol switch
            {
                "+" => calc.Add,
                "-" => calc.Subtract,
                "*" => calc.Multiply,
                "/" => calc.Divide,
                "%" => calc.Modulus,
                _ => null
            };

            if (operation == null)
            {
                Console.WriteLine("Entered operation is not valid");
                continue;
            }

            try
            {
                previousResult = operation(a, b);
                Console.WriteLine($"Result: {previousResult}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            Console.WriteLine("Do you want to perform another calculation with this result? (yes/no):");
            string continueResponse = Console.ReadLine().ToLower();
            continueCalculations = continueResponse == "yes";
        }
    }
}