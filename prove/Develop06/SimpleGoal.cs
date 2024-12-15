public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int MarkComplete()
    {
        IsCompleted = true;
        return Points;
    }

    public override string GetStatus()
    {
        return IsCompleted ? $"[X] {Name}" : $"[ ] {Name}";
    }

    public override string SaveRepresentation()
    {
        return $"SimpleGoal:{Name},{Points},{IsCompleted}";
    }
}