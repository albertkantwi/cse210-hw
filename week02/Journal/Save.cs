using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;

public class Save

{

    public static void SaveFile(List<EntryItems> journal)
    
    {
        string fileName = "";
        string cwd = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
        string fileExtension = ".json"; 
        bool unsaved = true; 

        while (unsaved)
        {
            Console.Write("Please enter the name of the file you would like to save (e.g., journal.json): ");
            string input = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("You must enter a valid file name. Please try again.");
                continue;
            }

            fileName = Path.Combine(cwd, input) + fileExtension;

            try
            {
                string jsonString = JsonSerializer.Serialize(
                    journal,
                    new JsonSerializerOptions { WriteIndented = true }
                );
               
                File.WriteAllText(fileName, jsonString);
                Console.WriteLine($"File saved successfully to {fileName}");
                unsaved = false;
                continue;         
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Your file did not save. Please try again. Exception type: {ex.GetType().Name}");
                continue; 
            }
        }
    }
}