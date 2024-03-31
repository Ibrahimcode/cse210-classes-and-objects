class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(
        string shortName, string description, int pointsValue, int target, int bonus, int amountCompleted=0, int accumulatedPoints=0
    ) : base(shortName, description, pointsValue, accumulatedPoints){
        this._target = target;
        this._bonus = bonus;
        this._amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted())
        {
            this._accumulatedPoints += this._pointsValue;
            this._amountCompleted += 1;
        }
    }

    public override bool IsCompleted()
    {
        return this._target == this._amountCompleted;
    }

    public override string GetStringDetails(){
        if (IsCompleted())
        {
            return $"[X] {this._shortName} ({this._description}) -- Currently completed {this._amountCompleted}/{this._target}";
        }
        return $"[ ] {this._shortName} ({this._description}) -- Currently completed {this._amountCompleted}/{this._target}";
    }

    public override GoalData GetGoalData()
    {
        return new GoalData{
            goalType = "Checklist",
            shortName = _shortName,
            description = _description,
            pointsValue = _pointsValue,
            accumulatedPoints = _accumulatedPoints,
            amountCompleted = this._amountCompleted,
            target = this._target,
            bonus = this._bonus
        };
    }
}