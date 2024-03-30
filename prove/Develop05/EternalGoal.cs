class EternalGoal : Goal
{
    public EternalGoal(
        string shortName, string description, int pointsValue
    ) : base(shortName, description, pointsValue){

    }

    protected override void RecordEvent()
    {
        this._accumulatedPoints += this._pointsValue;
        Console.WriteLine($"Congratulations! you have earned {this._pointsValue} points");
        // Console.WriteLine($"You now have {this._accumulatedPoints} points");
    }

    public override GoalData GetGoalData()
    {
        return new SimpleGoalData{
            goalType = "Eternal",
            shortName = _shortName,
            description = _description,
            pointsValue = _pointsValue,
            accumulatedPoints = _accumulatedPoints
        };
    }
}