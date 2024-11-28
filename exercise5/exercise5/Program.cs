using System;
using System.Collections.Generic;

class Program
{
    //// Function to find the maximum temperature
    //static int FindMaxTemperature(int n, List<int> temperatureChange)
    //{

    //    // Write your code here

    //}

    static void Main()
    {
        // Read input from stdin
        int n = int.Parse(Console.ReadLine());
        List<int> temperatureChange = new List<int>();

        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            temperatureChange.Add(int.Parse(input[i]));
        }

        // Call the function and display the result on stdout
        //int result = FindMaxTemperature(n, temperatureChange);
   

        Console.WriteLine(temperatureChange.Max());
    }
}
