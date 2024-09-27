using System;
using System.Net.Mail;
using System.Reflection;

class Program
{

// DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

// PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string inpNumber = Console.ReadLine();
        int number = int.Parse(inpNumber);
        return number;
    }
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

// DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }
    
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);






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
