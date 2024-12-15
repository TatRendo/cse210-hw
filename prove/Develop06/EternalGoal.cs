public class EternalGoal : Goal
{
    public int TimesRecorded { get; private set; }

    public EternalGoal(string name, int points) : base(name, points) 
    {
        TimesRecorded = 0;
    }

    public override int MarkComplete()
    {
        TimesRecorded++;
        return Points;
    }

    public override string GetStatus()
    {
        return $"[∞] {Name} - Recorded {TimesRecorded} times";
    }

    public override string SaveRepresentation()
    {
        return $"EternalGoal:{Name},{Points},{TimesRecorded}";
    }
}