
using System.Net.NetworkInformation;

class Goal
{
    protected string _shortName; 
    protected string _description;
    protected int _pointsValue;
    protected int _accumulatedPoints;

    public Goal(string shortName, string description, int pointsValue=0, int accumulatedPoints=0){
        this._shortName = shortName;
        this._description = description;
        this._pointsValue = pointsValue;
        this._accumulatedPoints = accumulatedPoints;
    }

    public virtual void RecordEvent(){
        return;
    }

    public virtual bool IsCompleted(){
        return false;
    }

    public virtual GoalData GetGoalData(){
        return new GoalData();
    } 

    public virtual string GetStringDetails(){
        return $"[ ] {this._shortName} ({this._description})";
    }
}