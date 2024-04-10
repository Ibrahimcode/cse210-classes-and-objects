class SleepAndRelaxationActivity : WellnessActivity
{
    // protected string _sacradeText;
    public SleepAndRelaxationActivity(
        string name, string description, string duration, bool completed)
    : base (name, description, duration, completed)
    {
        
    }

    protected override string buildActivityString(){
        return $"Your Sleep and Relaxation goal is: {this._name.ToUpper()} for {this._duration}";
    }
}