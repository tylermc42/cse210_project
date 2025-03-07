using System;

class Program
{
    static void Main(string[] args)
    {
        //create list
        List<int> numbers = new List<int>();

        // set variable
        int userNumber = -1;
        int sum = 0;
        int largest = 0;

        //start a loop to let user add numbers to a list
        while (userNumber != 0)
        {
            //get number
            Console.Write("Enter number(type 0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());
            //add number to list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            
        }

        //find the sum of the list
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //find average of list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is : {average}");


        //find highest nubmer
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}
