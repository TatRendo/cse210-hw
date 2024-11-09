using System;
class Program
{
    static void Main(string[]args)
   {
    bool keepPlaying = true;
    while (keepPlaying)
    { 
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int x = int.Parse(magic);
        int guess = 1;

        {
            while (guess != x)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (x > guess)
                {Console.WriteLine("Higher");}
                else if (x < guess)
                {Console.WriteLine("Lower");}
                else if (x == guess)
                {Console.WriteLine("You guessed it!");}
                else
                {Console.WriteLine("It's too far away");}
            }
        }
        Console.Write("Do you want to play again? (y/n): ");
        string response = Console.ReadLine().ToLower();
        keepPlaying = (response == "y" || response == "yes");
    }   
    Console.WriteLine("Thanks for playing. See you next time!");    
  }
}