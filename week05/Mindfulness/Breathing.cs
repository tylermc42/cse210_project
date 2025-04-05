using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This will help you relax by breathing slowly.")
        {
        }
    public void Run()
    {
        Start();
        int timePassed = 0;
        _duration = GetSecondsFromUser();
        while (timePassed < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            Wait(4);
            timePassed += 4;

            Console.WriteLine("Breathe out...");
            Wait(4);
            timePassed += 4;
            if (timePassed >= _duration)
            {
                break;
            }            
        }
        End();
    }
}