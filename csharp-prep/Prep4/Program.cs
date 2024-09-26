using System;

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
        
        // print statements

        Console.WriteLine("Here's your list");
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.WriteLine(numberList[i]);
        }

        Console.WriteLine();
        Console.WriteLine($"Your list has {listLen} numbers");
        Console.WriteLine($"Your list's sum is {listSum}");
        Console.WriteLine($"Your list's average is {listAvg}");
        Console.WriteLine($"Your list's highest number is {listMax}");

    }
}
//for (int i = 0; i < words.Count; i++)