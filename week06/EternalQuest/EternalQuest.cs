using System;
using System.Collections.Generic;
using System.IO;

public class EternalQuest
{
    private List<Goal> _goals;
    private int _score;
    private List<string> _badges;

    public EternalQuest()
    {
        _goals = new List<Goal>();
        _score = 0;
        _badges = new List<string>();
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nPick a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter number (1-3): ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name (avoid commas): ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description (avoid commas): ");
        string description = Console.ReadLine();

        try
        {
            if (choice == "1")
            {
                Console.Write("Enter a positive number for points: ");
                int points = int.Parse(Console.ReadLine());
                if (points <= 0) throw new ArgumentException("Points must be positive.");
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else if (choice == "2")
            {
                Console.Write("Enter a positive number for points per event: ");
                int pointsPerEvent = int.Parse(Console.ReadLine());
                if (pointsPerEvent <= 0) throw new ArgumentException("Points must be positive.");
                _goals.Add(new EternalGoal(name, description, pointsPerEvent));
            }
            else if (choice == "3")
            {
                Console.Write("Enter a positive number for points per event: ");
                int pointsPerEvent = int.Parse(Console.ReadLine());
                Console.Write("Enter a positive number for how many times to do it: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter a positive number for bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                if (pointsPerEvent <= 0 || targetCount <= 0 || bonusPoints <= 0)
                    throw new ArgumentException("All values must be positive.");
                _goals.Add(new ChecklistGoal(name, description, pointsPerEvent, targetCount, bonusPoints));
            }
            else
            {
                Console.WriteLine("Wrong choice!");
                return;
            }
            Console.WriteLine("Goal added!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter numbers.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("\nPick a goal number to mark done: ");
        try
        {
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < _goals.Count)
            {
                int points = _goals[index].RecordEvent();
                _score += points;
                Console.WriteLine($"Good job! You got {points} points. Total score: {_score}");
                CheckBadges();
            }
            else
            {
                Console.WriteLine("Bad number!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number!");
        }
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals yet!");
            return;
        }
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYour Score: {_score} points");
        if (_badges.Count > 0)
        {
            Console.WriteLine("Badges: " + string.Join(", ", _badges));
        }
        // Hint at next badge
        if (_score < 1000)
            Console.WriteLine("Keep going to earn the Bronze Star at 1000 points!");
        else if (_score < 5000)
            Console.WriteLine("Aim for the Silver Star at 5000 points!");
        else if (_score < 10000)
            Console.WriteLine("You're close to the Ninja Unicorn at 10000 points!");
    }

    public void SaveProgress()
    {
        Console.Write("Are you sure you want to save? This will overwrite existing data (y/n): ");
        if (Console.ReadLine().ToLower() != "y")
        {
            Console.WriteLine("Save cancelled.");
            return;
        }

        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(_score);
                writer.WriteLine(string.Join(";", _badges));
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.SaveData());
                }
            }
            Console.WriteLine("Saved!");
        }
        catch (IOException)
        {
            Console.WriteLine("Error saving file!");
        }
    }

    public void LoadProgress()
    {
        Console.Write("Are you sure you want to load? This will replace current progress (y/n): ");
        if (Console.ReadLine().ToLower() != "y")
        {
            Console.WriteLine("Load cancelled.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                string badgesLine = reader.ReadLine();
                if (!string.IsNullOrEmpty(badgesLine))
                {
                    _badges = new List<string>(badgesLine.Split(';'));
                }
                else
                {
                    _badges = new List<string>();
                }

                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];

                    if (type == "SimpleGoal")
                    {
                        string name = parts[1].Replace(";", ",");
                        string description = parts[2].Replace(";", ",");
                        int points = int.Parse(parts[3]);
                        bool completed = bool.Parse(parts[4]);
                        SimpleGoal goal = new SimpleGoal(name, description, points);
                        goal.RestoreState(completed);
                        _goals.Add(goal);
                    }
                    else if (type == "EternalGoal")
                    {
                        string name = parts[1].Replace(";", ",");
                        string description = parts[2].Replace(";", ",");
                        int pointsPerEvent = int.Parse(parts[3]);
                        int timesDone = int.Parse(parts[4]);
                        EternalGoal goal = new EternalGoal(name, description, pointsPerEvent);
                        goal.RestoreState(timesDone);
                        _goals.Add(goal);
                    }
                    else if (type == "ChecklistGoal")
                    {
                        string name = parts[1].Replace(";", ",");
                        string description = parts[2].Replace(";", ",");
                        int pointsPerEvent = int.Parse(parts[3]);
                        int targetCount = int.Parse(parts[4]);
                        int bonusPoints = int.Parse(parts[5]);
                        int currentCount = int.Parse(parts[6]);
                        bool completed = bool.Parse(parts[7]);
                        ChecklistGoal goal = new ChecklistGoal(name, description, pointsPerEvent, targetCount, bonusPoints);
                        goal.RestoreState(currentCount, completed);
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Loaded!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved file found!");
        }
        catch (Exception)
        {
            Console.WriteLine("Error loading file! Data may be corrupted.");
        }
    }

    private void CheckBadges()
    {
        if (_score >= 1000 && !_badges.Contains("Bronze Star"))
        {
            _badges.Add("Bronze Star");
            Console.WriteLine("Wow! You earned the Bronze Star badge! 🌟");
        }
        if (_score >= 5000 && !_badges.Contains("Silver Star"))
        {
            _badges.Add("Silver Star");
            Console.WriteLine("Awesome! You earned the Silver Star badge! ✨");
        }
        if (_score >= 10000 && !_badges.Contains("Ninja Unicorn"))
        {
            _badges.Add("Ninja Unicorn");
            Console.WriteLine("Amazing! You earned the Ninja Unicorn badge! 🦄🥷");
        }
    }
}