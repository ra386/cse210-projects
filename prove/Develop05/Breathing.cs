using System;
public class Breathing : Activity
{
    public Breathing () :base (" Breathing Activity", "his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing." )
    {


    }
    public void Run()
    {

        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(_Duration);

        // do StartTime < EndTime 
       do
       {
        

         Console.WriteLine();

         Console.Write("Breathe in..");
         Console.WriteLine();

         ShowCountDown(5);
         Console.WriteLine();
         Console.WriteLine("Breathe out...");
         Console.WriteLine();

         ShowCountDown(2);
         Console.WriteLine();

         DateTime currentTime = DateTime.Now;
        if (currentTime >= EndTime)
        {
            break;
        }

       }

       while ( StartTime <= EndTime);
       {
        Thread.Sleep(1000);
       }

         


    }

}