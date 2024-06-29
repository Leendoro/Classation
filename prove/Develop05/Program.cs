using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            var goals = new List<Goal>
            {
                new SimpleGoal("Run a marathon", 1000),
                new EternalGoal("Read scriptures", 100),
                new ChecklistGoal("Attend temple", 10, 50, 500)
            };
            

            // Menu loop
            while (true)
            {
                Console.WriteLine("Eternal Quest: Goal Tracking");
                Console.WriteLine("1. View Goals");
                Console.WriteLine("2. Record Progress");
                Console.WriteLine("3. Add New Goal");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Exit");

                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewGoals(goals);
                        break;
                    case "2":
                        RecordProgress(goals);
                        break;
                    case "3":
                        AddGoal(goals);
                        break;
                    case "4":
                        SaveGoals(goals);
                        break;
                    case "5":
                        LoadGoals(goals);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void ViewGoals(List<Goal> goals)
        {
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetStatus());
            }
        }

        static void RecordProgress(List<Goal> goals)
        {
            Console.WriteLine("Select a goal to record progress:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
            }
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < goals.Count)
            {
                goals[index].RecordProgress();
                Console.WriteLine("Progress recorded!");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        static void AddGoal(List<Goal> goals)
        {
            Console.WriteLine("Add a new goal:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Select a goal type: ");
            var choice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter completion points: ");
                    int simplePoints = int.Parse(Console.ReadLine());
                    goals.Add(new SimpleGoal(name, simplePoints));
                    break;
                case "2":
                    Console.Write("Enter points per completion: ");
                    int eternalPoints = int.Parse(Console.ReadLine());
                    goals.Add(new EternalGoal(name, eternalPoints));
                    break;
                case "3":
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter points per completion: ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, targetCount, checklistPoints, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }

        static void SaveGoals(List<Goal> goals)
        {
            // Implementation for saving goals to a file
        }

        static void LoadGoals(List<Goal> goals)
        {
            // Implementation for loading goals from a file
        }
    }
}


