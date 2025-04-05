using System;

class Program
{
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int listingCount = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("--Mindfullness Program--");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Show how many activities I've done");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                breathing.Run();
                breathingCount += 1;
            }
            else if (choice == "2")
            {
                reflection.Run();
                reflectionCount += 1;
            }
            else if (choice == "3")
            {
                listing.Run();
                listingCount += 1;
            }
            else if (choice == "4")
            {
                Console.WriteLine("\n--Amount of Activities--");
                Console.WriteLine($"Breathing Activity: {breathingCount}");
                Console.WriteLine($"Reflection Activity: {reflectionCount}");
                Console.WriteLine($"Listing Activity: {listingCount}");
                Console.WriteLine("\nPress Enter to return to menu");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nThank you for using the Mindfulness program! Goodbye");
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                breathing.Wait(3);
            }
        }
        }

}
