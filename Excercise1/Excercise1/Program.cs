internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        var firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        var lastName = Console.ReadLine();
        Console.WriteLine($"Hello {firstName} {lastName}");

        Console.WriteLine("Okay, now let's play few!");
        Console.WriteLine("Give me two numbers and I'll tell you sum of them");
        var number1 = int.Parse(Console.ReadLine());
        var number2 = int.Parse(Console.ReadLine());
        Console.WriteLine(number1 + number2);

        Console.WriteLine("Now give another two and I'll tell you division of them");
        var number3 = int.Parse(Console.ReadLine());
        var number4 = int.Parse(Console.ReadLine());
        Console.WriteLine(number3 / number4);
        Console.WriteLine(number3 % number4);

        Console.WriteLine("Let's make it harder,give me three numbers and I'll tell you multiplication of them");
        var number5 = int.Parse(Console.ReadLine());
        var number6 = int.Parse(Console.ReadLine());
        var number7 = int.Parse(Console.ReadLine());
        Console.WriteLine(number5 * number6 * number7);
        
        Console.WriteLine("And last one, tell me four numbers and I'll calculate average of them");
        var number8 = double.Parse(Console.ReadLine());
        var number9 = double.Parse(Console.ReadLine());
        var number10 = double.Parse(Console.ReadLine());
        var number11 = double.Parse(Console.ReadLine());
        Console.WriteLine((number8 + number9 + number10 + number11)/4);

        Console.WriteLine("It was funny playing with you. See you later, bye");

        //გავერთე:დდდ
    }
}




