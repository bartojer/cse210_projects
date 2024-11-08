using System;
using System.Collections.Generic;
using System.Threading;

class Breath: Activity{

    public Breath()
    {
        _name = "breathing";
        _verb = "breathe";
        _description = $"You and I are going to take {_duration} seconds to just breathe. Follow me into a world of peace and tranquility.";
        _ending = "Thank you for breathing with me. Peace be with you until we meet again.";
    }

    public void RunBreathing()
    {
        Console.Clear();
        if (_duration % 15 == 0)
        {  
            int _cycles = _duration / 15;

            Console.WriteLine($"We will be doing {_cycles} sets of 15 second box breathing");
            Console.Write("Begin in ");
            CountDown(3);
            Console.WriteLine();

            for (int i = 0; i < _cycles; i++)
            {
                BoxBreathCycle();
            }
        }
        else
        {
            int time = 0;
            while (time < _duration)
            {
                InOutBreathCycle();
                time += 10;
            }
        }
    }
    public static void BoxBreathCycle()
    {
        // 1 breathing cycle = 15 seconds
        Console.Write("Breath in ");
        Thread.Sleep(750);
        CountDown(3);
        Console.WriteLine();

        Console.Write("Hold ");
        Thread.Sleep(750);
        CountDown(3);
        Console.WriteLine();

        Console.Write("Breath out ");
        Thread.Sleep(750);
        CountDown(3);
        Console.WriteLine();

        Console.Write("Hold ");
        Thread.Sleep(750);
        CountDown(3);
        Console.WriteLine();
    }

    public static void InOutBreathCycle()
    {
        Console.Write("Breath in for ");
        CountDown(5);
        Console.WriteLine();
        Console.Write("Breath out for ");
        CountDown(5);
        Console.WriteLine();
    }
}
