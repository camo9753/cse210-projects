using System;

class Program
{
    public static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "B.A.E.";
        job1._startYear = 2001;
        job1._endYear = 2011;

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._company = "Lockheed Martin";
        job2._startYear = 2005;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "Cameron Rasmusson";

        myResume.DisplayResume();
    }
}