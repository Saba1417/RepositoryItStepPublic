internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter which side do you want to encryption. type 'left' or 'right'");
        var direction = Console.ReadLine();
        Console.WriteLine("now type index");
        var index = int.Parse(Console.ReadLine());
        Console.WriteLine("do you want 'encrypt' or 'decipher'?");
        var encOrDec = Console.ReadLine();
        if (encOrDec == "encrypt")
        {
            if (direction == "left") 
                index = -index;
        }
        else
        {
            if(direction == "right")
                index = -index;
        }
        //97-122
        var newText = string.Empty;
        Console.WriteLine("now enter the text");
        var text = Console.ReadLine().ToLower();
        for (int i = 0; i < text.Length; i++)
        {
            if ((int)text[i] < 97 || (int)text[i] > 122)
            {
                newText += " ";
                continue;
            }
             
            var ind = (int)text[i] + index;
            if (ind < 97)
                newText += (char)(123 - (97 -ind));
            else if (ind > 122)
                newText += (char)(96 + (ind-122));
            else
            {
                newText += (char)ind;
            }
        }
        Console.WriteLine(newText);
    }
}