public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference("Mosiah", 3, 19);

        string scriptureText = "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nYou have memorized the scripture!");
    }
}