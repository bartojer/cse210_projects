using System;
using System.Net.Mail;
using System.Reflection;

class Program
{
    static double CalcNumSquare(double number)
    {
        double square = number * number;
        return square;
    }

// DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

// PromptUserName - Asks for and returns the user's name (as a string)
    static void PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine(name);
    }
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static void PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string inpNumber = Console.ReadLine();
        double number = double.Parse(inpNumber);
        double squared = CalcNumSquare(number);
        Console.WriteLine(squared);
    }
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name and the squared number and displays them.

    
    static void Main(string[] args)
    {
        DisplayWelcome();













        // double radius = -1;
        // while (radius != 0)
        // {


        //     Console.WriteLine("What is the radius of your circle?");
        //     string inpRadius = Console.ReadLine();
        //     if ("0" == inpRadius)
        //     {
        //         break;
        //     }
        //     radius = double.Parse(inpRadius);
            
        //     Console.WriteLine(calc_circle_area(radius));
        //}
    }
}
