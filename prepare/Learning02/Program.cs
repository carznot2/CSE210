using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company="Microsoft";
        job1._JobTitle="Engineer";
        job1._startYear=2018;
        job1._endYear=2022;
        // job1.Display();
    
        Job job2 = new Job();
        job2._company="Apple";
        job2._JobTitle="Software Engineer";
        job2._startYear=2016;
        job2._endYear=2018;
        // job2.Display();

        Resume resume1 = new Resume();
        resume1._name="George";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}