using System;

class Program
{
    static void Main(string[] args)
    {
        // BreathActivity breathActivity = new BreathActivity(
        //     "Breath", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // breathActivity.Run();

        ListActivity listActivity = new ListActivity(
            "List",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the the power you have and how you can use it in other aspect of your life."
        );
        listActivity.Run();
    }
}