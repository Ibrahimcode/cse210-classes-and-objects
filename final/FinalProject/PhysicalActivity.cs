class PhysicalActivity : WellnessActivity
{
    protected string _intensity;
    protected List<string> _equipments;
    public PhysicalActivity(
        string name, string description, string duration, bool completed, string intensity, List<string> equipments)
    : base (name, description, duration, completed)
    {
        this._intensity = intensity;
        this._equipments = new List<string>();
        this._equipments = equipments;
    }

    protected override string buildActivityString(){
        return "";
    }
}