using System;

namespace Jobs
{
    public class Job
    {
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        // constructor
        public Job()
        {

        }

        // display job information

       public void DisplayJobInfo()
       {
        Console.WriteLine($"{_jobTitle} ({_company})  {_startYear}-{_endYear} ");
    
       }

    }
    
}