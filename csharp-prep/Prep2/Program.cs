using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string inp_grade = Console.ReadLine();
        int num_grade = int.Parse(inp_grade);
        string letter_grade;
        string passed = "Unfortunately you didn't pass this time around :( We hope you do better next time!";


        if (num_grade >= 90)
        {
            letter_grade = "A";
        }
        else if (num_grade >= 80)
        {
            letter_grade = "B";
        }
        else if (num_grade >= 70)
        {
            letter_grade = "C";
        }
        else if (num_grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        };

        if (num_grade >= 70)
        {
            passed = "Great job, you passed the class!";
        };

        Console.WriteLine($"Your letter grade is {letter_grade}.");
        Console.WriteLine(passed);
    }
}

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60