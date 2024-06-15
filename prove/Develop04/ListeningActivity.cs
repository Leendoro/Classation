class ListingActivity : MindfulnessActivity
{
    public void Run()
    {
        StartMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        Console.WriteLine("You have a few seconds to prepare...");
        ShowSpinner(3);
        Console.WriteLine("Start listing items:");
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }
        Console.WriteLine($"You listed {items.Count} items.");
        EndMessage("Listing Activity");
    }
}
