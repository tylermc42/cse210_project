using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        //create list to hold activities
        List<Activity> activities = new List<Activity>();

        //Add one of each activity
        activities.Add(new Running(new DateTime(2025, 4, 15), 30, 3.0)); //ran 3 miles
        activities.Add(new Cycling(new DateTime(2022, 4, 15), 45, 12.0)); //biked 12 miles
        activities.Add(new Swimming(new DateTime(2025, 4, 15), 20, 20)); //swam 20 laps

        //Loop through each activity and show summary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(); //blank line for readability
        }
    }
}