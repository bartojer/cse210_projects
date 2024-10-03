using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Developer";
        job1._startYear = "2017";
        job1._endYear = "2021";

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Dev Team Lead";
        job2._startYear = "2021";
        job2._endYear = "2024";

        Resume myResume = new();
        myResume._name = "Fizzle Fry";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}