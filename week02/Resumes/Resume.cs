using System;

public class Resume 
{
    //create class
    public string _name;
    // initialize list to new List
    public List<Job> _jobs = new List<Job>();
    //function to print data
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        //use loop to cycle through all jobs
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}