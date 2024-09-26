using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // List<int>numberList = [1,2,3];
        // foreach (int item in numberList)
        // {
        //     Console.WriteLine(item);
        // }

        // List<int> numberList2 = new();

        // int input = -1;
        // while (input != 0);
        // {
        //     Console.WriteLine("Enter an integer: ");
        //     string inputString = Console.ReadLine();
        //     input = int.Parse(inputString);
        //     if (input != 0)
        //     {
        //         numberList2.Add(input);
        //     }
        // }
        // foreach (int item in numberList2)
        // {
        //     Console.WriteLine(item);
        // }
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,2049);

        int numGuess = 0;
        while (numGuess != magicNumber)
        {
            Console.WriteLine("Guess the magic number: ");
            string guess = Console.ReadLine();
            numGuess = int.Parse(guess);

            if (numGuess < magicNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (numGuess > magicNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Yay");
            }
        }
    }
}