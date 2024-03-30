
using System.Net.NetworkInformation;

class Goal
{
    protected string _shortName; 
    protected string _description;
    protected int _pointsValue;
    protected int _accumulatedPoints;

    public Goal(string shortName, string description, int pointsValue=0){
        this._shortName = shortName;
        this._description = description;
        this._pointsValue = pointsValue;
    }

    protected virtual void RecordEvent(){
        return;
    }

    protected virtual bool IsCompleted(){
        return false;
    }

    protected virtual GoalData GetGoalData(){
        return new GoalData();
    } 
}