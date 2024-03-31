class EternalGoal : Goal
{
    public EternalGoal(
        string shortName, string description, int pointsValue, int accumulatedPoints=0
    ) : base(shortName, description, pointsValue, accumulatedPoints){

    }

    public override void RecordEvent()
    {
        this._accumulatedPoints += this._pointsValue;
    }

    public override GoalData GetGoalData()
    {
        return new GoalData{
            goalType = "Eternal",
            shortName = _shortName,
            description = _description,
            pointsValue = _pointsValue,
            accumulatedPoints = _accumulatedPoints
        };
    }
}