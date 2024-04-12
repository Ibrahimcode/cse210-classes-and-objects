class PhysicalActivity : WellnessActivity
{
    protected string _intensity;
    // protected List<string> _equipments;
    public PhysicalActivity(
        string name, string description, string duration, bool completed, string intensity)
    : base (name, description, duration, completed)
    {
        this._intensity = intensity;
        // this._equipments = new List<string>();
        // this._equipments = equipments;
    }

    protected override string buildActivityString(){
        // return $"You set a goal to do {this._intensity} {this._name} exercise for {this._duration},\n and you need these equipments to perform your physical exercise {this._equipments.ToString()}";
        return $"You set a goal to do {this._intensity} {this._name} exercise for {this._duration}.";
    }
}