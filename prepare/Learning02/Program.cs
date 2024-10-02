using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1997;
        job1._endYear = 2020;
        job1.DisplayJob();
        
        Job job2 = new();
        job2._company = "Apple";
        job2._jobTitle = "Marketing Specialist";
        job2._startYear = 1999;
        job2._endYear = 2022;
        job2.DisplayJob();

        Resume resume1 = new();
        resume1._name = "Timothy Clive";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();
    }
}