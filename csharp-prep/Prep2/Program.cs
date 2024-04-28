using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grades is a: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed, Good job!");
        }
        else
        {
            Console.WriteLine("sorry dude, Better luck next time!");
        }
    }
}