class MentalActivity : WellnessActivity
{
    protected string _focusArea;
    public MentalActivity(
        string name, string description, string duration, bool completed)
    : base (name, description, duration, completed)
    {
        
    }

    protected override string buildActivityString(){
        return $"To optimizee your mental health, you set a goal to practice {this._name} for {this._duration}";
    }
}