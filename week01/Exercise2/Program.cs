using System;

class Program
{
    static void Main(string[] args)
    {
        // Get number grade and convert to an integer
        Console.Write("What is your grade? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        string letter = "";

        // write if statments to print correct response for letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You recieved a {letter}");
    }
}