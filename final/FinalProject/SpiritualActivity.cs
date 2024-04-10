class SpiritualActivity : WellnessActivity
{
    protected string _sacradeText;
    public SpiritualActivity(
        string name, string description, string duration, bool completed, string sacradeText)
    : base (name, description, duration, completed)
    {
        this._sacradeText = sacradeText;
    }

    protected override string buildActivityString(){
        return "";
    }
}