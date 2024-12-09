using System;
using System.Runtime.CompilerServices;
public class Reflecting : Activity
{
        private List<string> _prompts;
        private List<string> _questions;


    public Reflecting () :base("Reflecting Activity","his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life." )
    {
        _prompts = new List<string>();
        _questions = new List<string>();
           // Prompt questions for the user
        _prompts.Add("--Think of a time when you stood up for someone else.--");
        _prompts.Add("--Think of a time when you did something really difficult.--");
        _prompts.Add("--Think of a time when you helped someone in need.--");
        _prompts.Add("--Think of a time when you did something truly selfless.--");
        _prompts.Add("--Think of a moment you felt genuinely happy for yourself.--");
        _prompts.Add("--Think of an event that has a special place in your heart.--");

        // questions

        _questions.Add("> Why was this experience meaningful to you? <");
        _questions.Add("> Have you ever done anything like this before? <");
        _questions.Add("> How did you get started? <");
        _questions.Add("> How did you feel when it was complete? <");
        _questions.Add("> What made this time different than other times when you were not as successful? <");
        _questions.Add("> What is your favorite thing about this experience? <");
        _questions.Add("> What could you learn from this experience that applies to other situations? <");
        _questions.Add("> What did you learn about yourself through this experience? <");
        _questions.Add("> How can you keep this experience in mind in the future? <");
         
    }

    public void Run()
    {
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(_Duration);
         bool isTimeUp = false;
        
        
        do 
        {
            Console.WriteLine("Consider the following prompts...");

            Random rand = new Random();
            int randomIndex = rand.Next(_prompts.Count);
            string randomQuestion = _prompts[randomIndex];
            Console.WriteLine(randomQuestion);
            Console.WriteLine();

            Console.WriteLine("When you have something in mind hit enter");
            Console.ReadLine();
            Console.Write("Tou begin in  ");
            ShowCountDown(10);

            Console.Clear();


            Console.WriteLine();

            foreach( string quest in _questions)
            {
                Console.WriteLine(quest);
                ShowSpinner(20);
                 if (DateTime.Now >= EndTime)
                {
                  isTimeUp = true;
                  break; // Exit the question loop
                }
            }

             DateTime currentTime = DateTime.Now;
            if (currentTime >= EndTime)
            {
               break;
            }


        }
        while (StartTime < EndTime);
    }

    

   

   

}