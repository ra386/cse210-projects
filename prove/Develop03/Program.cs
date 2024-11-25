using System;
using System.Collections.Generic;
// to exceed requirements my program hides words randomly but does not unhide an already hidden word

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.");
        
        Reference reference2 = new Reference("John", 3, 16);
        Scripture scripture2 = new Scripture(reference2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Random number = new Random();
        int numberToHide = number.Next(1, 6);                                      


        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        
        string input = "";

        while (input.ToLower() != "quit")
        {
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("The program has ended!");

                break;
            }                
            else if (!scripture1.IsCompleteHidden())
            {
                Console.Clear();
                scripture1.HideRandomWords(numberToHide);        
                Console.WriteLine(scripture1.GetDisplayText());
            }
            else
            {
                Console.WriteLine("Hope you memorised everything :]");
                break;
            }
        }

    

    }




    
}