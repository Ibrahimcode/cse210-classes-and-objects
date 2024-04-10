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

    public void DisplayProgress(){
        int activityIndex = 1;
        foreach (WellnessActivity wellnessActivity in this._wellnessActivities)
        {
            if(wellnessActivity.CheckCompletion()){
                Console.WriteLine($"  {activityIndex}. {wellnessActivity.GetType().ToString()} - {wellnessActivity.GetName()}  ✔");
            }else
            {
                Console.WriteLine($"  {activityIndex}. {wellnessActivity.GetType().ToString()} - {wellnessActivity.GetName()}  X");
            }
        }
    }
}