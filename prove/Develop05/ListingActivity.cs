public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity helps you reflect on the good things in your life by listing items.") 
    { }

    public override void Run(int duration)
    {
        StartActivity();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Start listing items. Press Enter after each one.");
        ShowCountdown(5);

        DateTime end = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < end)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndActivity(duration);
    }
}
