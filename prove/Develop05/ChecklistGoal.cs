using System;
using System.Collections.Generic;
using System.IO;

// Class for checklist goals
public class ChecklistGoal : Goal
{
    public int RewardPoints { get; set; }
    public int CompletionCount { get; set; }
    public int TargetCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int rewardPoints, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        RewardPoints = rewardPoints;
        CompletionCount = 0;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Event recorded for goal: {Name}");
        CompletionCount++;

        if (CompletionCount == TargetCount)
        {
            Console.WriteLine($"Goal {Name} completed {CompletionCount}/{TargetCount} times. Bonus points earned: {BonusPoints}");
            IsAchieved = true;
            return RewardPoints + BonusPoints;
        }
        else
        {
            Console.WriteLine($"Goal {Name} completed {CompletionCount}/{TargetCount} times.");
            return RewardPoints;
        }
    }

    public override bool IsComplete()
    {
        return IsAchieved;
    }

    public override void Save()
    {
        Console.WriteLine($"Saving checklist goal: {Name}");
    }

    public override void Load()
    {
        Console.WriteLine($"Loading checklist goal: {Name}");
    }
}