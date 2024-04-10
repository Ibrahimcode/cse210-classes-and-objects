class MentalActivity : WellnessActivity
{
    protected string _focusArea;
    public MentalActivity(
        string name, string description, string duration, bool completed, string focusArea)
    : base (name, description, duration, completed)
    {
        this._focusArea = focusArea;
    }

    protected override string buildActivityString(){
        return "";
    }
}