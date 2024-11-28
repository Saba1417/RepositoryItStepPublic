using System.Transactions;

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

        CalculatorDelegate addDelegate = new CalculatorDelegate(calc.Add);
        CalculatorDelegate subtractDelegate = new CalculatorDelegate(calc.Subtract);
        CalculatorDelegate multiplyDelegate = new CalculatorDelegate(calc.Multiply);
        CalculatorDelegate divideDelegate = new CalculatorDelegate(calc.Divide);
        CalculatorDelegate modulusDelegate = new CalculatorDelegate(calc.Modulus);

        CalculatorDelegate allOperations = addDelegate;
        allOperations += subtractDelegate;
        allOperations += multiplyDelegate;
        allOperations += divideDelegate;
        allOperations += modulusDelegate;

        Console.WriteLine("Enter two numbers");

        double a;
        bool success = double.TryParse(Console.ReadLine(), out a);

        double b;
        success = double.TryParse(Console.ReadLine(), out b);
        if (!success)
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        Console.WriteLine("Now enter operation symbol");

        var incomeLine = Console.ReadLine();

        CalculatorDelegate operation = new CalculatorDelegate(calc.Add);

        if (incomeLine == "+")
        {
            operation = new CalculatorDelegate(calc.Add);
        }
        else if (incomeLine == "-")
        {
            operation = new CalculatorDelegate(calc.Subtract);
        }
        else if (incomeLine == "*")
        {
            operation = new CalculatorDelegate(calc.Multiply);
        }
        else if (incomeLine == "/")
        {
            operation = new CalculatorDelegate(calc.Divide);
        }
        else if (incomeLine == "%")
        {
            operation = new CalculatorDelegate(calc.Modulus);
        }
        else
        {
            Console.WriteLine("Entered operation is not valid");
            return;
        }

        Console.WriteLine(operation(a, b));
    }
}