using System;
using System.Globalization;
using System.Net.Mail;
using System.IO;
using Develop02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine();

        Console.WriteLine("Welcome to the journal program");
        Console.WriteLine();

        string choice;
        PromptGenerator RandPrompt = new PromptGenerator();
        Journal journal1 = new Journal();
        // I added a numbered display of the total entries made by the user so he or she can track what they have writted and the intervals in which the have written.
        // I also added the opportunity for the user to input personalised entries giving a title for the entry and a response space making it it flexible either choosing prompts or manuall. 
     
        do
        {
            Console.WriteLine("1. Write a new entry (prompt)");
            Console.WriteLine("2. Personalised  entry");
            Console.WriteLine("3. Display the journal");
            Console.WriteLine("4. Save the journal");
            Console.WriteLine("5. Load the journal");
            Console.WriteLine("6. Exit");
            choice = Console.ReadLine();
            Console.WriteLine();

            
            
            Entries newEntry = new Entries(DateTime.Now);
      
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Write an entry:");
                    
                    Console.WriteLine("Prompt:  " + RandPrompt.GetRandomPrompt());
                    Console.Write("Response: ");
                    string answer = Console.ReadLine();
                    newEntry._PromptText = RandPrompt.GetRandomPrompt();
                    newEntry._Response = answer;
                    journal1.AddEntry(newEntry);
                    
                    break;

                case "2":
                      Console.WriteLine("What is the title of your entry: ");
                      string title = Console.ReadLine();
                      Console.WriteLine("Response: ");
                      string ans = Console.ReadLine();
                      newEntry._PromptText = title;
                      newEntry._Response = ans;
                      journal1.AddEntry(newEntry);

                       
                       break;
                case "3":
                     Console.WriteLine("Displaying Entries");
                     journal1.DisplayEntries();
                     int EntryCount = journal1._entries.Count;
                     Console.WriteLine($"Total entries made: {EntryCount}");
                    break;

                case "4":
                    Console.WriteLine("Enter a file name to save: ");
                    string save = Console.ReadLine();
                    journal1.SaveFile(save);
                    Console.WriteLine("Your jounal has been saved. ");
                    
                    break;

                case "5":
                        Console.Write("Enter filename to load: ");
                        string loadFilename = Console.ReadLine();
                        journal1.LoadFromFile(loadFilename);
                        Console.WriteLine("Journal loaded from file.");
                    break;

                case "6":
                       Console.WriteLine("Exiting the program");
                       break;

                default:
                     Console.WriteLine("Invalid choice please try again");
                     break;
            }
        }
        while (choice != "6");

    }
}