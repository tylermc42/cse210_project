using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        EternalQuest quest = new EternalQuest();

        while (true)
        {
            Console.WriteLine("\n=== Eternal Quest ===");
            Console.WriteLine("1. Add New Goal");
            Console.WriteLine("2. Mark Goal Done");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");
            Console.Write("Pick an option (1-7): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                quest.CreateGoal();
            }
            else if (choice == "2")
            {
                quest.RecordEvent();
            }
            else if (choice == "3")
            {
                quest.DisplayGoals();
            }
            else if (choice == "4")
            {
                quest.DisplayScore();
            }
            else if (choice == "5")
            {
                quest.SaveProgress();
            }
            else if (choice == "6")
            {
                quest.LoadProgress();
            }
            else if (choice == "7")
            {
                Console.WriteLine("See you later!");
                break;
            }
            else
            {
                Console.WriteLine("Pick a number from 1 to 7!");
            }
        }
    }
}