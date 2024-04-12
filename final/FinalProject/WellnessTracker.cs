class WellnessTracker
{
    public List<WellnessActivity> _wellnessActivities;

    public WellnessTracker(){
        this._wellnessActivities = new List<WellnessActivity>();
    }

    public void AddActivity(WellnessActivity activity){
        this._wellnessActivities.Add(activity);
    }

    public bool TrackProgress(){
        return false;
    }

    public void MarkComplete(int activityIndex){
         this._wellnessActivities[activityIndex].CompleteActivity();
    }

    public void DisplayProgress(){
        int activityIndex = 1;
        foreach (WellnessActivity wellnessActivity in this._wellnessActivities)
        {
            if(wellnessActivity.CheckCompletion()){
                Console.WriteLine($"  {activityIndex}. {wellnessActivity.GetType().ToString()} - {wellnessActivity.GetName()} [{wellnessActivity.GetDescription()}]  (Y)");
            }else
            {
                Console.WriteLine($"  {activityIndex}. {wellnessActivity.GetType().ToString()} - {wellnessActivity.GetName()} [{wellnessActivity.GetDescription()}]  (X)");
            }
            activityIndex++;
        }
    }

    public void DisplayActivityGoal(){
        Console.WriteLine();
        DisplayProgress();
        Console.WriteLine();
        Console.Write("Which activity goal do you want to see? ): ");
        int activityIndex = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine($"  {_wellnessActivities[activityIndex].GetName()} [{_wellnessActivities[activityIndex].GetDescription()}] ({(_wellnessActivities[activityIndex].CheckCompletion() ? "Completed" : "Not Yet Completed")})");
        _wellnessActivities[activityIndex].DisplayActivityGoal();
    }
}