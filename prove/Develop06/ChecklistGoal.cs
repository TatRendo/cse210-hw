public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override int MarkComplete()
    {
        if (IsCompleted) return 0;

        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            IsCompleted = true;
            return Points + BonusPoints;
        }
        return Points;
    }

    public override string GetStatus()
    {
        return IsCompleted 
            ? $"[X] {Name} - Completed {TargetCount}/{TargetCount} times" 
            : $"[ ] {Name} - Completed {CurrentCount}/{TargetCount} times";
    }

    public override string SaveRepresentation()
    {
        return $"ChecklistGoal:{Name},{Points},{CurrentCount},{TargetCount},{BonusPoints}";
    }
}