public class GoalManager
{
    public List<Goal> Goals { get; private set; }
    public int UserScore { get; private set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        UserScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordProgress(string goalName)
    {
        var goal = Goals.FirstOrDefault(g => g.Name == goalName);
        if (goal != null)
        {
            UserScore += goal.MarkComplete();
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
        Console.WriteLine($"Total Score: {UserScore}");
    }
}