using System;

class ReflectionActivity : Activity
{
    public ReflectionActivity() : base(
        "Reflection Activity",
        "Think about times when you were strong.")
    {
    }

    public void Run()
    {
        Start();
        string[] questions = {
            "Think of a time when you stood up for someone.",
            "Think of a time when you did something hard.",
            "Think of a time when you helped someone."            
        };
        Random rand = new Random();
        Console.WriteLine(questions[rand.Next(3)]);


        string[] moreQuestions = {
            "Why did this matter to you?",
            "How did you feel after",
            "What did you learn?"
        };
        while (true)
        {
            Console.WriteLine(moreQuestions[rand.Next(3)]);
            Console.Write("Press Enter to continue or type 'done' to finish: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            ShowDots(2);

        }
        End();
    }
}