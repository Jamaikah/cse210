using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        
        job1._jobTitle = "Software Engineer";
        job1._company = "Samsung";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();

        job2._jobTitle = "Web Developer";
        job2._company = "Meta";
        job2._startYear = 2021;
        job2._endYear = 2022;


        Resume resume = new Resume();

        resume._name = "Beta Test";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
    
}