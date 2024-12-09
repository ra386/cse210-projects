
using System;
using System.Net;

public class Listing : Activity
{
    private int _count;

    private List<string> Listprompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What makes you want to be a better person everyday"
    };

    
    private List<string> UserResponds = new List<string>();  

    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
        
    }


    public void Run()
    {
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(_Duration);

        while (StartTime < EndTime)
        {
            Console.WriteLine("List as many responses as you can to the following prompts");
            GetRandomPrompt();

            Console.Write("You may begin in ");
            ShowCountDown(5);
            Console.WriteLine();

            string response = Console.ReadLine();
            UserResponds.Add(response);

            StartTime = DateTime.Now; 
        }

        Console.WriteLine("Time is up! Thank you for participating.");

       
    }

    public void GetRandomPrompt()
    {
        Random index = new Random();
        int randomPos = index.Next(Listprompts.Count);
        string randomPrompt = Listprompts[randomPos];
        Console.WriteLine($" --- {randomPrompt} --- ");

        
    }


}