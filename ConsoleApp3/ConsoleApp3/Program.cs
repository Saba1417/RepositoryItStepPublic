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

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        foreach (CalculatorDelegate operation in allOperations.GetInvocationList())
        {
            try
            {
                double result = operation(a, b);
                Console.WriteLine($"{operation.Method.Name}: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{operation.Method.Name}: {ex.Message}");
            }
        }
    }
}