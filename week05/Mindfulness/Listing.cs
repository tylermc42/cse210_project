using System;

class ListingActivity : Activity
{
    public ListingActivity() : base(
        "Listing Activity",
        "List good things in your life.")
    {
    }

    public void Run()
    {
        Start();
        string[] thingsToList = {
            "What caught your eye today?",
            "What are you good at?",
            "Who are your heroes?"
        };
        Random rand = new Random();
        Console.WriteLine(thingsToList[rand.Next(3)]);

        Console.WriteLine("Start Listing (type 'done' when finished):");
        int itemCount = 0;


        while (true)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
            {
                break;
            }
            if (item != "")
            {
                itemCount += 1;
            }
            Console.WriteLine($"\nYou listed {itemCount} things.");
        }
        
        End();
    }
}