using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
    
    // create first job and add data
    Job job1 = new Job();
    job1._jobTitle = "Software Engineer";
    job1._company = "Microsoft";
    job1._startYear = 2023;
    job1._endYear = 2025;
    //create second job and add data
    Job job2 = new Job();
    job2._jobTitle = "Software Developer";
    job2._company = "Apple";
    job2._startYear = 2019;
    job2._endYear= 2023;

    // create resume class 
    Resume myResume = new Resume();
    //add name to resume
    myResume._name = "Tyler McCleve";
    //add created jobs to resume
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.Display();

    }
}
