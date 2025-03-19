using System;
//I exceeded requirements by adding multiple scriptures that the program will randomly choose from when it is ran
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him."),
            new Scripture(new Reference("Matthew", 6, 33), "But seek first his kingdom and his righteousness, and all these things will be given to you as well.")
        };

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ending.");

    }
}