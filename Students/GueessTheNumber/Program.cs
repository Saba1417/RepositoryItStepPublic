
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please enter range with 2 numbers");
        int a;
        bool success = int.TryParse(Console.ReadLine(), out a);

        int b;
        success = int.TryParse(Console.ReadLine(), out b);
        if (!success)
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        var randonNumber = RandomNumberGenerator(a, b);
        int counter = 0;
        Console.WriteLine("Now try to guess number");
        while (true)
        {
            int choosenNumber;
            bool success1 = int.TryParse(Console.ReadLine(), out choosenNumber);
            if (!success)
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }
            counter++;
            if (choosenNumber == randonNumber)
            {
                Console.WriteLine("Congratulations! You're right!");
                Console.WriteLine($"It took you {counter} tries.");
                break;
            }
            else if (choosenNumber > randonNumber)
            {
                Console.WriteLine("You need to try lower number");
            }
            else if (choosenNumber < randonNumber)
            {
                Console.WriteLine("You need to try higher number");
            }

        }

    }

    static int RandomNumberGenerator(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}