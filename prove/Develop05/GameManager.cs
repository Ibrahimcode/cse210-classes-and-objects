class GameManager
{
    public List<Goal> _goals;
    public int  _score;

    public GameManager(){
        this._score = 0;
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"Your total current score is: {this._score}");
    }

    public void ListGoalNames(){
        int goalIndex = 1;
        foreach (Goal goal in this._goals)
        {
            Console.WriteLine($"{goalIndex}. {goal.GetGoalData().shortName}");
            goalIndex++;
        }
    }

    public void ListGoalDetails(){
        int goalIndex = 1;
        foreach (Goal goal in this._goals)
        {
            Console.WriteLine($"{goalIndex}. {goal.GetStringDetails()}");
            goalIndex++;
        }
    }
}