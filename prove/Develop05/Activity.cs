using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready to begin...");
        ShowCountdown(3);
    }

    public void EndActivity(int duration)
    {
        Console.WriteLine("\nGood job!!! Finaly. You have completed the activity.");
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"Duration: {duration} seconds.");
        ShowCountdown(3);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int duration)
    {
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }

    public abstract void Run(int duration);
}