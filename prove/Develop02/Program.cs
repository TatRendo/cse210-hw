using System;

public class Program
{
    public static void Main()
    {
        Journal journal = new Journal();
        string[] prompts = {
            "¿What did I do today and how did I feel about it?",
            "¿What important goals or tasks did .... today?",
            "¿Was there anything significant or inusual that happened today??",
            "¿What decisions did I make today that could impact my future?",
            "What am I grateful for today and why?"
        };

        while (true)
        {
            Console.WriteLine("--- Option menu ---");
            Console.WriteLine("1. Write in the diary");
            Console.WriteLine("2. Show the diary");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Random random = new Random();
                    string prompt = prompts[random.Next(prompts.Length)];
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "4":
                    Console.Write("Enter the file name to upload: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
 
                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}