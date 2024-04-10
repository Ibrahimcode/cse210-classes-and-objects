using System.ComponentModel.DataAnnotations;

class WellnessActivity
{
    protected string _name;
    protected string _description;
    protected string _duration;
    protected bool _completed;

    public WellnessActivity(string name, string description, string duration, bool completed){
        this._name = name;
        this._description = description;
        this._duration = duration;
        this._completed = completed;
    }

    public virtual void DisplayActivityGoal(){
        Console.WriteLine(this.buildActivityString());
    }

    public virtual bool CheckCompletion(){
        return this._completed;
    }

    public string GetName(){
        return this._name;
    }

    protected virtual string buildActivityString(){
        return "";
    }
}