using System.Runtime.InteropServices;

class MedicalActivity : WellnessActivity
{
    protected string _time;
    protected string _purpose;
    public MedicalActivity(
        string name, string description, string duration, bool completed, string time, string purpose)
    : base (name, description, duration, completed)
    {
        this._time = time;
        this._purpose = purpose;
    }

    protected override string buildActivityString(){
        return "";
    }
}