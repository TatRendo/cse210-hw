var manager = new GoalManager();

manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
manager.AddGoal(new EternalGoal("Read Scriptures", 100));
manager.AddGoal(new ChecklistGoal("Attend the temple", 50, 10, 500));

manager.RecordProgress("Read Scriptures");
manager.RecordProgress("Attend the temple");

manager.DisplayGoals();
