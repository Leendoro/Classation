using System;
using System.Collections.Generic;
using System.Threading;


class MindfulnessActivity
{
    protected int duration;

    public void StartMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.Write("Enter duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void EndMessage(string activityName)
    {
        Console.WriteLine($"Good job! You've completed the {activityName}.");
        Console.WriteLine($"Duration: {duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine("Activity finished.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

