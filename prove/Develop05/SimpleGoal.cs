using System;
using System.Collections.Generic;
using System.IO;

// Class for simple goals
public class SimpleGoal : Goal
{
    public int RewardPoints { get; set; }

    public SimpleGoal(string name, string description, int points, int rewardPoints)
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
        Console.WriteLine($"Saving simple goal: {Name}");
    }

    public override void Load()
    {
        Console.WriteLine($"Loading simple goal: {Name}");
    }
}