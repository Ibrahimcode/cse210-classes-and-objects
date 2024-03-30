class GameManager
{
    public List<Goal> _goals;
    public int  _score;

    public GameManager(){
        this._score = 0;
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You now have {this._score} points");
    }

    public void ListGoalNames(){
        int goalIndex = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in this._goals)
        {
            Console.WriteLine($"{goalIndex}. {goal.GetGoalData().shortName}");
            goalIndex++;
        }
    }

    public void ListGoalDetails(){
        int goalIndex = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in this._goals)
        {
            Console.WriteLine($"{goalIndex}. {goal.GetStringDetails()}");
            goalIndex++;
        }
    }

    public void CreateGoal(){
        Console.WriteLine("The types of goals are:");
        Console.WriteLine($"  1. Simple Goal");
        Console.WriteLine($"  2. Eternal Goal");
        Console.WriteLine($"  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userCreateGoal = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int amountOfPoints = int.Parse(Console.ReadLine());

        switch (userCreateGoal)
        {
            case "1":
                this._goals.Add( new SimpleGoal(goalName, goalDescription, amountOfPoints));
                break;
            case "2":
                this._goals.Add( new EternalGoal(goalName, goalDescription, amountOfPoints));
                break;
            case "3":
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                this._goals.Add( new ChecklistGoal(goalName, goalDescription, amountOfPoints, target, bonus));
                break;
            default:
                Console.WriteLine("Please choose a valid goal.");
                break;
        }

    }

    public void RecordEvent(){
        this.ListGoalNames();
        Console.Write("Which goal did you accomplished? ");
        int goalToRecord = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (goalToRecord - 1  <= this._goals.Count)
        {
            int goalIndex = goalToRecord - 1;
            this._goals[goalIndex].RecordEvent();
            GoalData goalData = this._goals[goalIndex].GetGoalData();

            this._score += goalData.pointsValue;

            Console.WriteLine($"Congratulations! you have earned {goalData.pointsValue} points!");
            this.DisplayPlayerInfo();

        }
    }
}