using System;

public class PromptGenerator
{
    // variables - create prompts list
    List<string> _prompts = new List<string>
    {
        "If you could simplify the day into one lesson topic, what would it be?",
        "What did you learn today that you want to remember?",
        "What goal for the day did I not complete that I should have?",
        "What did your kids do today that you found memorable?",
        "Which emotion were you feeling most of the day and why?"
    };
    public Random _random = new Random();

    // function - pick random prompt
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}


