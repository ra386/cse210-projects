using System;
using Jobs;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "Software Developper";
        job1._startYear = 2017;
        job1._endYear = 2020;
        job2._company = "Microsoft";

        job2._jobTitle = "Backend Developper";

        
        job2._startYear = 2021;

        
        job2._endYear = 2023;


        job1.DisplayJobInfo();
        job2.DisplayJobInfo();

        Resume resume = new Resume();

        resume._personName = "Favour Junior Uche Ebere";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
        

        
      }
    
    }
