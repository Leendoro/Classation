class BreathingActivity : MindfulnessActivity
{
    public void Run()
    {
        StartMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            elapsedTime += 3;
            Console.WriteLine("Breathe out...");
            Countdown(3);
            elapsedTime += 3;
        }
        EndMessage("Breathing Activity");
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
