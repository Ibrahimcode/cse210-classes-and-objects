class EternalGoal : Goal
{
    public EternalGoal(
        string shortName, string description, int pointsValue
    ) : base(shortName, description, pointsValue){

    }

    public override void RecordEvent()
    {
        this._accumulatedPoints += this._pointsValue;
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