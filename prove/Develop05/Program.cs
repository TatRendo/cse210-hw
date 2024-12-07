class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "4") break;

            Console.Write("Enter duration in seconds: ");
            int duration;
            if (!int.TryParse(Console.ReadLine(), out duration))
            {
                Console.WriteLine("Invalid duration. Try again.");
                Thread.Sleep(2000);
                continue;
            }

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run(duration);
                    break;
                case "2":
                    new ReflectionActivity().Run(duration);
                    break;
                case "3":
                    new ListingActivity().Run(duration);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
