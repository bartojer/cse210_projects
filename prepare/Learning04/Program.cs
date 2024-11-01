using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment( "Steven", "Phishing");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment =  new MathAssignment("John", "Algebra", "Chapter 3", "3.1-3.5");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        
        WritingAssignment writingAssignment = new WritingAssignment("Jane", "Poetry", "The Road Not Taken");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}