internal class Program
{
    private static void Main(string[] args)
    {
        var length = int.Parse(Console.ReadLine());
        int[] ints = new int[length];

        var number1 = int.Parse(Console.ReadLine());
        AddElementAtStart(ints, number1);

        var number2 = int.Parse(Console.ReadLine());

        AddElementAtEnd(ints, number2);

        var number3 = int.Parse(Console.ReadLine());
        var index = int.Parse(Console.ReadLine());
        AddElementAtIndex(ints, number3, index);

        DeleteElementAtStart(ints);

        DeleteElementAtEnd(ints);

        DeleteElementAtIndex(ints, int.Parse(Console.ReadLine()));
    }

    static void AddElementAtStart(int[] ints, int value)
    {
        var temp = new int[ints.Length +1];
        temp[0] = value;
        for (int i = 0; i< ints.Length; i++)
        {
            temp[i+1] = ints[i];
        }
        foreach (int i in temp)
        {
            Console.WriteLine(i);
        }
    }

    static void AddElementAtEnd(int[] ints, int value)
    {
        var temp = new int[ints.Length + 1];
        for (int i = 0; i < ints.Length; i++)
        {
            temp[i] = ints[i];
        }
        temp[ints.Length] = value;
        foreach (int i in temp)
        {
            Console.WriteLine(i);
        }
    }

    static void AddElementAtIndex(int[] ints,  int value, int index)
    {
        var temp = new int[ints.Length + 1];
        for (int i = 0; i < index; i++)
        {
            temp[i] = ints[i];
        }
        temp[index] = value;
        for (int i = index +1 ; i < ints.Length; i++)
        {
            temp[i] = ints[i];
        }
        foreach (int i in temp)
        {
            Console.WriteLine(i);
        }
    }

    static void DeleteElementAtStart(int[] ints)
    {
        var temp = new int[ints.Length - 1];
        
        for (int i = 1; i < ints.Length; i++)
        {
            temp[i -1] = ints[i];
        }
        foreach (int i in temp)
        {
            Console.WriteLine(i);
        }
    }

    static void DeleteElementAtEnd(int[] ints)
    {
        var temp = new int[ints.Length - 1];
        for (int i = 0; i < ints.Length -1 ; i++)
        {
            temp[i] = ints[i];
        }
        foreach (int i in temp)
        {
            Console.WriteLine(i);
        }
    }

    static void DeleteElementAtIndex(int[] ints, int index)
    {
        var temp = new int[ints.Length - 1];
        for (int i = 0; i < index; i++)
        {
            temp[i] = ints[i];
        }
        for (int i = index + 1; i < ints.Length; i++)
        {
            temp[i -1] = ints[i];
        }
        foreach (int i in temp)
        {
            Console.WriteLine(i);
        }
    }

}