using System;

public class Program
{
    public static void Main()
    {
        Journal journal = new Journal();
        string[] prompts = {
            "¿Quién fue la persona más interesante con la que interactué hoy?",
            "¿Cuál fue la mejor parte de mi día?",
            "¿Cómo vi la mano del Señor en mi vida hoy?",
            "¿Cuál fue la emoción más fuerte que sentí hoy?",
            "Si tuviera que hacer una cosa hoy, ¿qué sería?"
        };

        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Escribir una nueva entrada");
            Console.WriteLine("2. Mostrar el diario");
            Console.WriteLine("3. Guardar el diario en un archivo");
            Console.WriteLine("4. Cargar el diario desde un archivo");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");
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
                    Console.Write("Ingresa el nombre del archivo para guardar: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "4":
                    Console.Write("Ingresa el nombre del archivo para cargar: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}