using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();
        text.CapitalizeSentenses();
    }
}

static class DateTimeExtensions
{
    public static bool IsWeekend(this DateTime dateTime)
    {
        if (dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday) { return true; }
        return false;
    }

}

static class IntExtensions
{
    public static bool IsEven(this int ints)
    {
        if (ints % 2 == 0) { return true; }
        return false;
    }

    public static bool IsOdd(this int ints)
    {
        if (ints % 2 == 0) { return true; }
        return false;
    }

}

static class StringExtensions
{
    public static void CapitalizeSentenses(this string s)
    {
        if (string.IsNullOrEmpty(s)) return;
        var splitted =  s.Split('.',StringSplitOptions.RemoveEmptyEntries);

        s = "";
        foreach(string str in splitted)
        {
            
            var firstLetter = str[0].ToString();
            var UpperfistLetter = firstLetter.ToUpper();
            var ind = str.Length - 1;
            var newStr = str.TakeLast(ind);

            s += UpperfistLetter;
            foreach(char ch in newStr)
            {
                s += ch;
            }
           
            s +=".";
        }
        Console.WriteLine(s);
        
    }
}

static class IEnumerableExtensions
{
    public static void Shuffle(this IEnumerable<person>[] person)
    {
        Random rnd = new Random();
        rnd.Shuffle(person);
    }
}

public class person
{
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } = string.Empty;

}