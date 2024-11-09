using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What was your test score? ");
        string number = Console.ReadLine();
        int score = int.Parse(number);
        string letter = "";
        int range = score % 10;

        

        if ( score >= 90)
        {
           letter = "A";
           if (range >= 7)
            {
               
            }
            else if (range < 5)
            {
                letter += "-";
            }
        }
        else if ( score >= 80)
        {
            letter = "B";
            if (range > 7)
            {
                letter += "+";
            }
            else if (range < 3)
            {
                letter += "-";
            }
        }
        else if ( score >= 70)
        {
            letter = "C";
            if (range > 7)
            {
                letter += "+";
            }
            else if (range < 3)
            {
                letter += "-";
            }
        }
        else if ( score >= 60)
        {
            letter = "D";
            if (range > 7)
            {
                letter += "+";
            }
            else if (range < 3)
            {
                letter += "-";
            }
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (score >= 70)
        {
            Console.WriteLine("You passed the course");
        }
        else 
        {
            Console.WriteLine("Better luck next time");
        }
    }
}