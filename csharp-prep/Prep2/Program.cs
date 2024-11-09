using System;

class Program
{
    static void Main(string[]args)
   {
     {
        Console.Write("Enter your grade percentage: ");
        String note = Console.ReadLine();

        int x = int.Parse(note);

        if (x >= 91)
        { Console.WriteLine("Your grade is: A+");}
        else if (x == 90)
        { Console.WriteLine("Your grade is: A");}
        else if (x >= 81)
        { Console.WriteLine("Your grade is: B+");}
        else if (x == 80)
        { Console.WriteLine("Your grade is: B");}
        else if (x >= 71)
        { Console.WriteLine("Your grade is: C+");}
        else if (x == 70)
        { Console.WriteLine("Your grade is: C");}
        else if (x >= 61)
        { Console.WriteLine("Your grade is: D+");}
        else if (x == 60)
        { Console.WriteLine("Your grade is: D");}
        else if (x == 59)
        { Console.WriteLine("Your grade is: F");}
        else
        { Console.WriteLine("Your grade is: F-");}

        if (x >= 70)
        { Console.WriteLine("Your passed");}
        else
        {
            Console.WriteLine("Better luck next time");
        }
     }
    }
}

