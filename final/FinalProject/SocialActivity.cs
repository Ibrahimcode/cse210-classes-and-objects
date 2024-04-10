class SocialActivity : WellnessActivity
{
    protected string _groupSize;
    //protected string _activityType; // indoor or outdoor

    public SocialActivity(
        string name, string description, string duration, bool completed, string groupSize /*string activityType*/)
    : base (name, description, duration, completed)
    {
        //this._activityType = activityType;
        this._groupSize = groupSize;
    }

    protected override string buildActivityString(){
        return $"Your social activity goal is {this._name} with {this._groupSize} people. You need to do this for {this._duration}";
    }
}