class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(
        string shortName, string description, int pointsValue
        ) : base(shortName, description, pointsValue){
        this._isComplete = false;
    }

    protected override void RecordEvent()
    {
        this._accumulatedPoints += this._pointsValue;
        this._isComplete = true;
        Console.WriteLine($"Congratulations! you have earned {this._pointsValue} points");
        Console.WriteLine($"You now have {this._accumulatedPoints} points");
    }

    protected override bool IsCompleted()
    {
        return this._isComplete;
    }

    protected override GoalData GetGoalData()
    {
        return new SimpleGoalData{
            goalType = "Simple",
            shortName = _shortName,
            description = _description,
            pointsValue = _pointsValue,
            accumulatedPoints = _accumulatedPoints,
            isCompleted = _isComplete
        };
    }
}