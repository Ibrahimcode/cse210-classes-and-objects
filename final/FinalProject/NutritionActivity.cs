class NutritionActivity : WellnessActivity
{
    protected List<string> _foodNutrients;
    public NutritionActivity(
        string name, string description, string duration, bool completed, List<string> foodNutriients)
    : base (name, description, duration, completed)
    {
        this._foodNutrients = new List<string>();
        this._foodNutrients = foodNutriients;
    }

    protected override string buildActivityString(){
        return $"Your Nutrition goal is {this._name}. You also wants to consume these nutrients: {this._foodNutrients.ToString()} for {this._duration}";
    }
}