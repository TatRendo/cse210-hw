using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        bool continueProgram = true;
        
        while (continueProgram)
        {
            Console.WriteLine("\n--- Options Menu ---");
            Console.WriteLine("1. Enter the number");
            Console.WriteLine("2. Delete number");
            Console.WriteLine("3. Show the sorted list");
            Console.WriteLine("0. Type 0 when finished");
            Console.Write("Select an option (0-3): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the number: ");
                    if (int.TryParse(Console.ReadLine(), out int newNumber))
                    {
                        numbers.Add(newNumber);
                        Console.WriteLine($"The number '{newNumber}' has been added.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                
                case "2":
                    Console.Write("Enter the number to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int numToRemove) && numbers.Contains(numToRemove))
                    {
                        numbers.Remove(numToRemove);
                        Console.WriteLine($"The number '{numToRemove}' has been removed.");
                    }
                    else
                    {
                        Console.WriteLine($"'{numToRemove}' was not found or is invalid.");
                    }
                    break;
                
                case "3":
                    Console.WriteLine("\nThe sorted list is:");
                    numbers.Sort();
                    foreach (int num in numbers)
                    {
                        Console.WriteLine(num);
                    }
                    break;

                case "0":
                    continueProgram = false;
                    Console.WriteLine("See you soon.");
                    break;
                
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"\nThe sum is: {sum}");

        if (numbers.Count > 0)
        {
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        else
        {
            Console.WriteLine("No numbers entered for calculating average.");
        }

        if (numbers.Count > 0)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max is: {max}");
        }
    }
}