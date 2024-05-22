
using System;

using System;
using System.Collections.Generic;
using System.IO;



class Program {
    static void Main(string[] args) {
        Journal journal = new Journal();
        string choice;

        do {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    Console.WriteLine("Write a new entry:");
                    string prompt = GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response, DateTime.Now.ToString());
                    break;
                case "2":
                    Console.WriteLine("Journal Entries:");
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != "5");
    }

    static string GetRandomPrompt() {
        // List of prompts
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to the digital Journal");
//     }
    

//     List<string> promts = new List<string>
//     {
//     ("Who was the most interesting person I interacted with today?"),
//     ("What was the best part of my day?"),
//     ("How did I see the hand of the Lord in my life today?"),
//     ("What was the strongest emotion I felt today?"),
//     ("If I had one thing I could do over today, what would it be?"),
//     ("What went wrong today?")
//     };

    

    








// };


