using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear la lista vacía
        List<string> numbers = new List<string>();
        
        // Variable de control para el bucle
        bool continueProgram = true;
        
        while (continueProgram)
        {
            Console.WriteLine("\n--- Menú de Opciones ---");
            Console.WriteLine("1. Enter the number: ");
            Console.WriteLine("2. Delete number: ");
            Console.WriteLine("3. The sorted list is: ");
            Console.WriteLine("0. Etype 0 when finished:");
            Console.Write("Select an option (0-3): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the number: ");
                    string newNumber = Console.ReadLine();
                    numbers.Add(newNumber);
                    Console.WriteLine($"La palabra '{newNumber}' has been add.");
                    break;
                
                case "2":
                    Console.Write("Delete number: ");
                    string numToRemove = Console.ReadLine();
                    if (numbers.Remove(numToRemove))
                    {
                        Console.WriteLine($"The '{numToRemove}' has been removed.");
                    }
                    else
                    {
                        Console.WriteLine($"'{numToRemove}' was not found.");
                    }
                    break;
                
                case "3":
                    Console.WriteLine("\nThe sorted list is:");
                    foreach (string num in numbers)
                    {
                        Console.WriteLine(num);
                    }
                    break;

                case "0":
                    continueProgram = false;
                    Console.WriteLine("¡See you soon.");
                    break;
                
                default:
                    Console.WriteLine("The option is not valid. Try again.");
                    break;
            }
        }
    }
}