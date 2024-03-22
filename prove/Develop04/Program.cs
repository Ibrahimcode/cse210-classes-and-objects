using System;

class Program
{
    static void Main(string[] args)
    {
        BreathActivity breathActivity = new BreathActivity(
            "Breath", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        breathActivity.Run();
    }
}