public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract int MarkComplete();
    public abstract string GetStatus();
    public abstract string SaveRepresentation();
}