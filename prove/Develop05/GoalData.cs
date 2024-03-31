
class GoalData
{
    public string goalType {get; set;}

    public string shortName {get; set;}
    public string description {get; set;}
    public int pointsValue {get; set;}
    public int accumulatedPoints {get; set;}
    public bool isCompleted {get; set;}
    public int amountCompleted {get; set;}
    public int target {get; set;}
    public int bonus {get; set;}
}

// class SimpleGoalData : GoalData
// {
//     public bool isCompleted {get; set;}
// }

// class ChecklistGoalData : GoalData
// {
//     public int amountCompleted {get; set;}
//     public int target {get; set;}
//     public int bonus {get; set;}
// }