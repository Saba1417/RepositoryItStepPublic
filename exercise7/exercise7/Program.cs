internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter triangle sides:");
        Triangle triangle = new Triangle();
        double[] triangleSides = { double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()) };

        Console.WriteLine($"perimeter is: {triangle.CalculatePerimeter(triangleSides)}");


        Console.WriteLine("Enter rectangle sides:");
        Rectangle rectangle = new Rectangle();
        double[] rectangleSides = { double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()) };

        Console.WriteLine($"perimeter is: {rectangle.CalculatePerimeter(rectangleSides)}");

        Console.WriteLine("Enter circle radius:");
        circle circle = new circle();
        double[] circleRadius = { double.Parse(Console.ReadLine()) };

        Console.WriteLine($"perimeter is: {circle.CalculatePerimeter(circleRadius)}");

    }
}
abstract class Shape
{
    public virtual double CalculatePerimeter(double[] doubles)
    {   
        var sum = 0.0;
        for (int i = 0; i < doubles.Length; i++) {
            sum += doubles[i];
        }
        return sum;
    }
}

class Triangle : Shape
{
    public override double CalculatePerimeter(double[] doubles)
    {
        return base.CalculatePerimeter(doubles);
    }
}

class Rectangle : Shape
{
    public override double CalculatePerimeter(double[] doubles)
    {
        return base.CalculatePerimeter(doubles);
    }
}

class circle : Shape
{
    public override double CalculatePerimeter(double[] doubles)
    {
        var radius = doubles[0];
        return Math.PI * radius * 2;
    }
}