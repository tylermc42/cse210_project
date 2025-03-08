using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");


    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        DisplayResult(userName, squared);
    }
    }

    // functions
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    

    
}


