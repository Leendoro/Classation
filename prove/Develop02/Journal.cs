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
