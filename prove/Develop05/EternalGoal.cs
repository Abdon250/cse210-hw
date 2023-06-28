using System;
using System.Collections.Generic;
using System.IO;

// Class for eternal goals
public class EternalGoal : Goal
{
    public int RewardPoints { get; set; }

    public EternalGoal(string name, string description, int points, int rewardPoints)
        : base(name, description, points)
    {
        RewardPoints = rewardPoints;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Event recorded for goal: {Name}");
        IsAchieved = true;
        return RewardPoints;
    }

    public override bool IsComplete()
    {
        return IsAchieved;
    }

    public override void Save()
    {
        Console.WriteLine($"Saving eternal goal: {Name}");
    }

    public override void Load()
    {
        Console.WriteLine($"Loading eternal goal: {Name}");
    }
}