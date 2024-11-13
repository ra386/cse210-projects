using System;
namespace Jobs
{
    public class Resume
    {
        public string _personName;
        public List<Job> _jobs;

        //constructor

        public Resume()
        {
            _jobs = new List<Job>();
        }

        public void DisplayResume()
        {
            Console.WriteLine($"Resume of {_personName}:");

            foreach ( var job in _jobs)
            {
                job.DisplayJobInfo();
            }
        }
    }
}