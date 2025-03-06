using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //set magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int userNumber = -1;

        // use loops to give hints till guess is right
        while (userNumber != magicNumber)
        {
            // get number from user
            Console.Write("What is the magic number? ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
                
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
    }
}

