using System;

class Program
{
    static void Main(string[] args)
    {   
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Dave's Bouncy House Rental";
        job1._startYear = 1991;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Google Inc.";
        job2._startYear = 2012;
        job2._endYear = 2020;

        Resume resume1 = new Resume();
        resume1._name = "Douglas Jameson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();
    }
}