// Base class for goals
public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsAchieved { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsAchieved = false;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract void Save();
    public abstract void Load();
}