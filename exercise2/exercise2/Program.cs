internal class Program
{
    private static void Main(string[] args)
    {
        //1
        Console.WriteLine("Enter two numbers");
        bool ans1 = int.TryParse(Console.ReadLine(), out int num1);
        bool ans2 = int.TryParse(Console.ReadLine(), out int num2);
        if (ans1 && ans2)
        {
            var sub = num1 - num2;
            var sum = num1 + num2;
            var multiply = num1 * num2;
            var division = num1 / num2;

            Console.WriteLine($"Sum: " + sum.ToString() + " Subtraction: " + sub.ToString() + " Multiplication: " + multiply.ToString() + " Division: " + division.ToString());
        }
        else
        {
            Console.WriteLine("Wrong input");
        }

        Console.WriteLine();
        //2
        Console.WriteLine("Enter three numbers");
        bool ans3 = double.TryParse(Console.ReadLine(), out double num3);
        bool ans4 = double.TryParse(Console.ReadLine(), out double num4);
        bool ans5 = double.TryParse(Console.ReadLine(), out double num5);
        if (ans3 && ans4 && ans5)
        {
            var iNum3 = 1;
            var iNum4 = 1;
            var iNum5 = 1;

            var j = num3;
            while (j >= 1)
            {
                j = j / 10;
                iNum3 *= 10;
            }

            j = num4;
            while (j >= 1)
            {
                j = j / 10;
                iNum4 *= 10;
            }

            j = num5;
            while (j >= 1)
            {
                j = j / 10;
                iNum5 *= 10;
            }

            double sumdouble = num3 + num4/iNum4 + num4 + num5/iNum5;
            Console.WriteLine(sumdouble);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }


        Console.WriteLine();
        //triangles
        Console.WriteLine("Do you want to draw traingles?");
        var answer = Console.ReadLine();
        if (answer.ToLower() == "yes")
            DrawTriangles();    
     }

    static void DrawTriangles()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            for (int j = 10; j > i; j--)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i <= j)
                    Console.Write('*');
                else
                    Console.Write(' ');
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            for (int j = 9; j >= 0; j--)
            {
                if (i >= j)
                    Console.Write('*');
                else
                    Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}