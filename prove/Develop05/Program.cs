using System;
using System.Collections.Generic;
using System.IO;

// Main program
public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static string goalsFilePath = "goals.txt";

    public static void Main()
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Create Goal");
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter goal type: ");
        string goalTypeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalTypeChoice)
        {
            case "1":
                Console.Write("Enter reward points for simple goal: ");
                int rewardPoints = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(name, description, points, rewardPoints));
                Console.WriteLine("Simple goal created.");
                break;
            case "2":
                Console.Write("Enter reward points for eternal goal: ");
                int eternalRewardPoints = int.Parse(Console.ReadLine());
                goals.Add(new EternalGoal(name, description, points, eternalRewardPoints));
                Console.WriteLine("Eternal goal created.");
                break;
            case "3":
                Console.Write("Enter reward points for checklist goal: ");
                int checklistRewardPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter target count for checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for checklist goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, checklistRewardPoints, targetCount, bonusPoints));
                Console.WriteLine("Checklist goal created.");
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal creation failed.");
                break;
        }
    }

    private static void ListGoals()
    {
        Console.WriteLine("List Goals");

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        int achievedCount = 0;
        int pendingCount = 0;

        foreach (var goal in goals)
        {
            Console.WriteLine($"Goal Name: {goal.Name}");
            Console.WriteLine($"Goal Description: {goal.Description}");
            Console.WriteLine($"Goal Points: {goal.Points}");
            Console.WriteLine($"Goal Completion: {(goal.IsComplete() ? "Achieved" : "Pending")}");

            if (goal.IsComplete())
                achievedCount++;
            else
                pendingCount++;

            Console.WriteLine();
        }

        Console.WriteLine($"Total Goals: {goals.Count}");
        Console.WriteLine($"Achieved Goals: {achievedCount}");
        Console.WriteLine($"Pending Goals: {pendingCount}");
    }

    private static void SaveGoals()
{
    Console.WriteLine("Save Goals");
    Console.WriteLine("Enter the file name (without extension):");
    string fileName = Console.ReadLine();

    Console.WriteLine("Select file format:");
    Console.WriteLine("1. TXT");
    Console.WriteLine("2. CSV");

    Console.Write("Enter file format: ");
    string fileFormatChoice = Console.ReadLine();

    string filePath = "";

    switch (fileFormatChoice)
    {
        case "1":
            filePath = $"{fileName}.txt";
            break;
        case "2":
            filePath = $"{fileName}.csv";
            break;
        default:
            Console.WriteLine("Invalid file format. Goals not saved.");
            return;
    }

    using (StreamWriter writer = new StreamWriter(filePath))
    {
        foreach (var goal in goals)
        {
            goal.Save();
            if (goal is SimpleGoal simpleGoal)
            {
                writer.WriteLine($"{goal.Name},{goal.Description},{goal.Points},{goal.IsAchieved},{simpleGoal.RewardPoints}");
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                writer.WriteLine($"{goal.Name},{goal.Description},{goal.Points},{goal.IsAchieved},{checklistGoal.TargetCount},{checklistGoal.BonusPoints},{checklistGoal.RewardPoints}");
            }
        }
    }

    Console.WriteLine("Goals saved successfully.");
}

private static void LoadGoals()
{
    Console.WriteLine("Load Goals");
    Console.WriteLine("Enter the file name (without extension):");
    string fileName = Console.ReadLine();

    Console.WriteLine("Select file format:");
    Console.WriteLine("1. TXT");
    Console.WriteLine("2. CSV");

    Console.Write("Enter file format: ");
    string fileFormatChoice = Console.ReadLine();

    if (!int.TryParse(fileFormatChoice, out int format))
    {
        Console.WriteLine("Invalid file format. Goals not loaded.");
        return;
    }

    string filePath = "";

    switch (format)
    {
        case 1:
            filePath = $"{fileName}.txt";
            break;
        case 2:
            filePath = $"{fileName}.csv";
            break;
        default:
            Console.WriteLine("Invalid file format. Goals not loaded.");
            return;
    }

    if (!File.Exists(filePath))
    {
        Console.WriteLine("Goals file not found. Load failed.");
        return;
    }

    goals.Clear();

    using (StreamReader reader = new StreamReader(filePath))
    {
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] goalData = line.Split(',');

            string name = goalData[0];
            string description = goalData[1];
            int points = int.Parse(goalData[2]);
            bool isAchieved = bool.Parse(goalData[3]);

            Goal goal;

            if (isAchieved)
            {
                int rewardPoints = int.Parse(goalData[4]);
                goal = new SimpleGoal(name, description, points, rewardPoints);
            }
            else
            {
                int targetCount = int.Parse(goalData[4]);
                int bonusPoints = int.Parse(goalData[5]);
                int rewardPoints = int.Parse(goalData[6]);
                goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints, rewardPoints);
            }

            goal.IsAchieved = isAchieved;
            goals.Add(goal);
        }
    }

    Console.WriteLine("Goals loaded successfully.");
}


    private static void RecordEvent()
    {
        Console.WriteLine("Record Event");

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found. Event recording failed.");
            return;
        }

        Console.WriteLine("Select the goal to record an event for:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter the goal number: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > goals.Count)
        {
            Console.WriteLine("Invalid goal number. Event recording failed.");
            return;
        }

        var goal = goals[goalNumber - 1];
        var pointsEarned = goal.RecordEvent();
        Console.WriteLine($"Points earned for goal {goal.Name}: {pointsEarned}");
    }
}