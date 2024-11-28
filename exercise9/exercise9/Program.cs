using System;

internal class Program
{
    private static void Main(string[] args)
    {
        MyObject obj1 = new MyObject { MyValue = 10 };
        MyObject obj2 = new MyObject { MyValue = 20 };
        MyObject maxObj = FindMaximum(obj1, obj2);
        Console.WriteLine($"Maximum MyObject value: {maxObj.MyValue}");
    }

    static T FindMaximum<T>(T obj1, T obj2) where T : IComparable<T>
    {
        return obj1.CompareTo(obj2) > 0 ? obj1 : obj2;
    }
}

class MyObject : IComparable<MyObject>
{
    public int MyValue { get; set; }

    public int CompareTo(MyObject? obj)
    {
        if (obj == null) return 1;
        return MyValue.CompareTo(obj.MyValue);
    }
}
