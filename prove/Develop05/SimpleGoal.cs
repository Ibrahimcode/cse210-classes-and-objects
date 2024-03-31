class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(
        string shortName, string description, int pointsValue, int accumulatedPoints=0
        ) : base(shortName, description, pointsValue, accumulatedPoints){
        this._isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted())
        {
            this._accumulatedPoints += this._pointsValue;
            this._isComplete = true;
        }
        
    }

    public override bool IsCompleted()
    {
        return this._isComplete;
    }

    public override string GetStringDetails(){
        if (IsCompleted())
        {
            return $"[X] {this._shortName} ({this._description})";
        }
        return $"[ ] {this._shortName} ({this._description})";
    }

    public override GoalData GetGoalData()
    {
        return new GoalData{
            goalType = "Simple",
            shortName = _shortName,
            description = _description,
            pointsValue = _pointsValue,
            accumulatedPoints = _accumulatedPoints,
            isCompleted = _isComplete
        };
    }
}