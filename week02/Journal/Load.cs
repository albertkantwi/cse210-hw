using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Load
{
    
    public static List<EntryItems> LoadFile()
    
    {
        string toDeserialize = ""; 
        string fileName = ""; 
        string cwd = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
        string fileExtension = ".json"; 
        while (true)
        {
            Console.Write("Please enter the name of the file you would like to load (e.g., journal.json): ");
            string input = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("You must enter a valid file name. Please try again.");
                continue;
            }

            fileName = Path.Combine(cwd, input) + fileExtension;

            try
            {
                toDeserialize = File.ReadAllText(fileName);
                List<EntryItems>? journal = JsonSerializer.Deserialize<List<EntryItems>>(toDeserialize);

                if (journal != null)
                {
                    Console.WriteLine($"File '{fileName}' loaded successfully!");
                    return journal;
                }
                else
                {
                    Console.WriteLine("File loaded but contained no entries.");
                    return new List<EntryItems>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Your file did not load. Exception type: {ex.GetType().Name}");
                Console.WriteLine("Please try again.");
            }
        }
    }
}