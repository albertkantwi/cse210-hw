using System;
using System.Collections.Generic;

public class Entry

{

    public EntryItems journalEntries()
    
    {

        string todaysEntry = "";
        EntryItems journalEntry = new EntryItems();
        DateTime currentDate = DateTime.Today;
        Prompt todaysPrompt = new Prompt();
        string livePrompt = todaysPrompt.GetPrompt();
        Console.WriteLine($"Welcome to your Journal.\nToday's date is {currentDate.ToShortDateString()}");
        Console.WriteLine("Your topic for today is: \n");

        Console.WriteLine(livePrompt + Environment.NewLine);
        while (true)
        {
            Console.Write("Please begin your Journal Entry: ");
            todaysEntry = Console.ReadLine();

            if (todaysEntry != "")
            {
                journalEntry = EntryItems.CreateEntryListItem(currentDate, livePrompt, todaysEntry);
                return journalEntry;
            }
            else
            {
                Console.WriteLine("You must make an entry. ");
            }
        }
    }
}