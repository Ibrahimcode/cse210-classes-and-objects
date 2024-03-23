using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathActivity breathActivity = new BreathActivity(
                        "Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathActivity.Run();
                    break;

                case "2":
                    ListActivity listActivity = new ListActivity(
                        "Listing",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                    );
                    listActivity.Run();
                    break;

                case "3":
                    ReflectingActivity reflectingActivity = new ReflectingActivity(
                        "Reflecting",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the the power you have and how you can use it in other aspect of your life."
                    );
                    reflectingActivity.Run();
                    break;

                default:
                    choice = "4";
                    break;
            }
        }
    }
}