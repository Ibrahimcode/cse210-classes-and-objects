using System;

class Program
{
    
    static void Main(string[] args)
    {
        GoalSetting goalSetting = new GoalSetting();

        Console.WriteLine("This program will help you to maintain the Seven Pillars of Brain Health");
        Console.WriteLine("You will set goals on all seven wellness activty and tracks whether you complete each.");


        bool quit = false;

        while (!quit)
        {
            Console.WriteLine();
            Console.WriteLine("1. Set goals");

            Console.WriteLine("2. Complete a goal");

            Console.WriteLine("3. Track progress");

            Console.WriteLine("4. Display a single activity goal");

            Console.WriteLine("5. quit");

            string goalOption = Console.ReadLine();

            switch (goalOption)
            {
                case "1":
                    goalSetting.SetGoal();
                    break;

                case "2":
                    goalSetting.CompleteActivity();
                    break;

                case "3":
                    goalSetting.TrackProgress();
                    break;

                case "4":
                    goalSetting.DisplaySingleActivityGoal();
                    break;

                default:
                    quit = true;
                    break;
            }
        }

    }

    
}