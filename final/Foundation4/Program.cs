using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = [];        
        exercises.Add(new Run("12/10/2024", 30, 2));
        exercises.Add(new Bicycle("12/10/2024", 20, 15));
        exercises.Add(new Swim("12/9/2024", 20, 8));
        
        Console.WriteLine("GO HARD EVERY DAY! [press enter to see your exercise summary]");
        Console.ReadLine();

        Console.WriteLine("\nYour exercise summary:\n");
        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
        Console.WriteLine("\nGood job for exercising. Your future self thanks you, as do I.\n");
    }
}