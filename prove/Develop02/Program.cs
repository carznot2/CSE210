using System;

class Program
{
    static void Main(string[] args)
    {
        // Journal object
        Journal journal=new Journal();
        
        Console.WriteLine("Menu Options\n" +
            "1. Add Entry\n" +
            "2. Display Entries\n" +
            "3. Save Entries\n" +
            "4. Load Entries\n" +
            "5. Exit"
        );
        string option=Console.ReadLine();
        switch (option)
        {
            case "1":
                journal.AddEntry();
                break;
            case "2":
                journal.DisplayEntries();
                break;
            case "3":
                journal.Save();
                break;
            case "4":
                journal.Load();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}