using System;
using System.Collections.Generic;


public class Activity
{
    protected string _Name;
    protected string _Description;
    protected int _Duration;

    public Activity ()
    {

    }

    public Activity( string Name, string Description)
    {
        _Name = Name;
        _Description = Description;
        // _Duration = Duration;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the  {_Name}");
        Console.WriteLine();
        Console.WriteLine($"{_Description}");
        Console.WriteLine();

        Console.Write("How long in seconds will you want this to last");
        _Duration = int.Parse(Console.ReadLine());
    
        Console.Clear();
        Console.WriteLine("Get Ready.....");
        ShowSpinner(10);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($" The {_Name} Activity is completed");
        Console.WriteLine($"You have completed {_Duration} seconds, Awsome Keep up");

    }

    public void ShowCountDown(int seconds)
    {
        for (int i=seconds; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // public void ShowCountDown(int Seconds)
    // {
    //     for ( int i = 0; i < Seconds + 10 ; i--)
    //     {
    //         Console.WriteLine($"{i}..");
    //         Thread.Sleep(1000);
    //         Console.Write("\b \b");
    //     }

    // }

    // public void ShowSpinner(int Seconds)
    // {
    //     List<string> Animation = new List<string>();
    //     Animation.Add("|");
    //     Animation.Add("/");
    //     Animation.Add("-");
    //     Animation.Add("\\");

    //     foreach ( string S in Animation)
    //     {
    //         Console.WriteLine(S);
    //         Thread.Sleep(1000);
    //         Console.Write("\b \b");
    //     }

    // }

     public void ShowSpinner(int Seconds)
    {
        List<string> animamationString = new List<string>() {"|","/","-","\\",};
        int i = 0;
        while (Seconds > i)
        {
            foreach (string s in animamationString)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
            i++;
        }
    }

}