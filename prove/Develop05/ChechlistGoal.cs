class ChechlistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChechlistGoal(
        string shortName, string description, int pointsValue, int target, int bonus
    ) : base(shortName, description, pointsValue){
        this._target = target;
        this._bonus = bonus;
    }

    protected override void RecordEvent()
    {
        this._accumulatedPoints += this._pointsValue;
        this._amountCompleted += 1;
        Console.WriteLine($"Congratulations! you have earned {this._pointsValue} points");
        Console.WriteLine($"You now have {this._accumulatedPoints} points");
    }

    protected override bool IsCompleted()
    {
        return this._target == this._amountCompleted;
    }

    protected override string GetStringDetails(){
        if (IsCompleted())
        {
            return $"[X] {this._shortName} ({this._description}) -- Currently completed {this._accumulatedPoints}/{this._target}";
        }
        return $"[ ] {this._shortName} ({this._description}) -- Currently completed {this._accumulatedPoints}/{this._target}";
    }

    protected override GoalData GetGoalData()
    {
        return new ChecklistGoalData{
            goalType = "Simple",
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