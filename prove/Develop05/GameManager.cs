using System.Net;
using System.Text.Json;

class GameManager
{
    public List<Goal> _goals;
    public int  _score;

    public GameManager(){
        this._goals = new List<Goal>();
        this._score = 0;
    }

    public void Start(){
        string menuOption;
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOption =  Console.ReadLine();

            switch (menuOption)
            {
                case "1":
                    this.CreateGoal();
                    break;
                case "2":
                    this.ListGoalDetails();
                    break;
                case "3":
                    this.SaveGoals();
                    break;
                case "4":
                    this.LoadGoals();
                    break;
                case "5":
                    this.RecordEvent();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    quit = true;
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"You have {this._score} points");
            Console.WriteLine();
        }
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You now have {this._score} points");
    }

    public void ListGoalNames(){
        int goalIndex = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in this._goals)
        {
            Console.WriteLine($"  {goalIndex}. {goal.GetGoalData().shortName}");
            goalIndex++;
        }
    }

    public void ListGoalDetails(){
        int goalIndex = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in this._goals)
        {
            Console.WriteLine($"  {goalIndex}. {goal.GetStringDetails()}");
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
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the amount of points associated with this goal? ");
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
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
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

            // Check to add bonus for Checklist goal.
            if (goalData.goalType == "Checklist" && this._goals[goalIndex].IsCompleted())
            {
                // ChecklistGoalData checklistGoalData = (ChecklistGoalData)goalData;
                // this._score += checklistGoalData.bonus;
                this._score += goalData.bonus;
            }

            Console.WriteLine($"Congratulations! you have earned {goalData.pointsValue} points!");
            this.DisplayPlayerInfo();

        }
    }

    public void SaveGoals(){
        List<GoalData> goalDatum = new List<GoalData>();

        foreach (Goal goal in this._goals)
        {
            goalDatum.Add(goal.GetGoalData());
        }

        Console.Write("What is the filename of the goal? ");
        string goalFileName = Console.ReadLine();
        
        using (StreamWriter goalFile = new StreamWriter(goalFileName))
        {
            string goalJsonString = JsonSerializer.Serialize(goalDatum);
            goalFile.WriteAsync(goalJsonString);
        }
    }

    public void LoadGoals(){
        List<GoalData> goalDatum = new List<GoalData>();

        Console.Write("What is the filename of the goal? ");
        string goalFileName = Console.ReadLine();
        
        using (StreamReader goalFile = new StreamReader(goalFileName))
        {
            string goalJsonString = goalFile.ReadToEnd();
            goalDatum = JsonSerializer.Deserialize<List<GoalData>>(goalJsonString);
        }

        // Create goals from the goal data and add them
        // to the list of _goal
        foreach (GoalData goalData in goalDatum)
        {
            this._score += goalData.accumulatedPoints;
            string goalType = goalData.goalType;
            switch (goalType)
            {
                case "Simple":
                    this._goals.Add(new SimpleGoal(goalData.shortName, goalData.description, goalData.pointsValue, goalData.accumulatedPoints));
                    break;
                case "Eternal":
                    this._goals.Add(new EternalGoal(goalData.shortName, goalData.description, goalData.pointsValue, goalData.accumulatedPoints));
                    break;
                case "Checklist":
                    // ChecklistGoalData checklistGoalData = (ChecklistGoalData)goalData;
                    this._goals.Add(new ChecklistGoal(goalData.shortName, goalData.description, goalData.pointsValue, goalData.target, goalData.bonus, goalData.amountCompleted, goalData.accumulatedPoints));
                    break;
                default:
                    break;
            }
        }
    }
}