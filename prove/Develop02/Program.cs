
using System;

using System;
using System.Collections.Generic;
using System.IO;

class Entry {
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
}

class Journal {
    private List<Entry> entries;

    public Journal() {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, string date) {
        entries.Add(new Entry { Prompt = prompt, Response = response, Date = date });
    }

    public void DisplayEntries() {
        foreach (var entry in entries) {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename) {
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (var entry in entries) {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename) {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                string[] parts = line.Split('|');
                entries.Add(new Entry { Date = parts[0], Prompt = parts[1], Response = parts[2] });
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}

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


