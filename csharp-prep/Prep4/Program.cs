using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your new list program. Add as many integers as you like, then type '0' to finish and display the list.");

        List<int> numberList = new();
        int numInput = -1;
        while (numInput != 0)
        {
            Console.Write("> ");
            string strInput = Console.ReadLine();
            numInput = int.Parse(strInput);
            if (numInput != 0)
            {
                numberList.Add(numInput);
            }
        }
    
        int listSum = numberList.Sum();
        double listAvg = numberList.Average();
        int listMax = numberList.Max();
        int listLen = numberList.Count;

        int lowPosNum = int.MaxValue;
        foreach (int item in numberList)
        {
            if (item > 0)
            {
                if (item < lowPosNum)
                {
                    lowPosNum = item;
                }
            }
        }

        int highNegNum = int.MinValue;
        foreach (int item in numberList)
        {
            if (item < 0)
            {
                if (item > highNegNum)
                {
                    highNegNum = item;
                }
            }
        }
    
        // print statements

        Console.WriteLine("Here's your list");
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.WriteLine(numberList[i]);
        }

        Console.WriteLine();
        Console.WriteLine("These are some stats for your list:");
        Console.WriteLine($"Total numbers: {listLen}");
        Console.WriteLine($"Sum: {listSum}");
        Console.WriteLine($"Average value: {listAvg}");
        Console.WriteLine($"Highest number: {listMax}");
        Console.WriteLine($"Lowest positive number: {lowPosNum}");
        Console.WriteLine($"Highest negative number: {highNegNum}");
    }
}
//for (int i = 0; i < words.Count; i++)