class SocialActivity : WellnessActivity
{
    protected string _groupSize;
    protected string _activityType;

    public SocialActivity(
        string name, string description, string duration, bool completed, string groupSize, string activityType)
    : base (name, description, duration, completed)
    {
        this._activityType = activityType;
        this._groupSize = groupSize;
    }

    protected override string buildActivityString(){
        return "";
    }
}