using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new RunningActivity("03 Aug 2024", 35, 10.0);
        Activity cycling = new CyclingActivity("28 Mar 2024", 20, 25.0);
        Activity swimming = new SwimmingActivity("17 Jul 2024", 45, 40);

        List<Activity> activities = new List<Activity> {running, cycling, swimming};

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}