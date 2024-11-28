internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

        Console.WriteLine("Enter coordinates and the value");
        int ind = 0;
        var alreadyEntered = new string[matrix.GetLength(0) * matrix.GetLength(1)];
        while (ind < matrix.GetLength(0) * matrix.GetLength(1)) {
            var ind1 = int.Parse(Console.ReadLine());
            var ind2 = int.Parse(Console.ReadLine());

            if (ind1 > matrix.GetLength(0) - 1 || ind2 > matrix.GetLength(1) - 1) {
                Console.WriteLine("index out of orders, please enter right values");
                continue;
            }
            else {
                matrix[ind1, ind2] = int.Parse(Console.ReadLine());
                var str1 = ind1.ToString();
                var str2 = ind2.ToString();
                if (alreadyEntered.Contains($"{str1} {str2}"))
                {
                    Console.WriteLine("entered coordinates are already filled");
                }
                else
                {
                    alreadyEntered[ind] = $"{str1} {str2}";
                    ind++;
                }
            }
            foreach (var s in alreadyEntered) {
                Console.WriteLine(s);
            }
        }
        Console.WriteLine("Here's your array");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine(matrix[i, j]);
            }
        }

    }
}