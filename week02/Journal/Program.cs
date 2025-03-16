using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        //create journal
        Journal myjournal = new Journal();
        //set one instance of random prompt
        PromptGenerator promptGenerator = new PromptGenerator();
        //set boolean variable to true to start program
        bool run = true;

        while (run)
        {
            // create list with all options
            List<string> options = new List<string>
            {
                "1. Write a new entry",
                "2. Display all entries in your journal",
                "3. Save the Journal to a file",
                "4. Load the Journal from a file",
                "5. Quit"
            };

            Console.WriteLine("Welcome to your Journal, here are your options.");

            // iterate through list and print each option
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            // prompt and save users choice
            Console.Write("Please select an option: ");
            int userChoice = int.Parse(Console.ReadLine());

            //if statments to reflect what the user wants to do
            if (userChoice == 1)
            {
                Console.WriteLine("Today's prompt is:");

                //get random prompt and user response
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                //exceeding requirements
                //ask user to rate the day on a scale of 1-10
                Console.Write("Please rate the day on a scale of 1-10, 10 being happy on how the day went and 1 being extremely displeased on how the day went. ");
                string userRating = Console.ReadLine();

                // create a new entry
                Entry newEntry = new Entry();
                //get date
                newEntry._date = DateTime.Now.ToString("yyy-MM-dd");
                //convert promptGenerator to a string and set
                newEntry._promptText = prompt;
                //set response 
                newEntry._entryText = response;
                //set daily rating
                newEntry._entryRate = userRating;

                //save new entry to journal
                myjournal.AddEntry(newEntry);
            }
            else if (userChoice == 2)
            {
                myjournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("What is the file name you want to save to? ");
                string filename = Console.ReadLine();
                myjournal.SaveToFile(filename);
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the file name you want to upload from? ");
                string filename = Console.ReadLine();
                myjournal.LoadFromFile(filename);
            }
            else if (userChoice == 5)
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid response. Enter valid choice");
            }
            ;

        }
    }

}