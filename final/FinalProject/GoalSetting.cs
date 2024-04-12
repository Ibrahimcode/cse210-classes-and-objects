class GoalSetting
{
    private WellnessTracker wellnessTracker = new WellnessTracker();
    public void SetGoal(){
        Console.WriteLine("Choose the goal you want to set:");
        Console.WriteLine("  1. Physical Goal");
        Console.WriteLine("  2. Mental Goal");
        Console.WriteLine("  3. Social Goal");
        Console.WriteLine("  4. Spiritual Goal");
        Console.WriteLine("  5. Sleep and Relaxation Goal");
        Console.WriteLine("  6. Nutrition Goal");
        Console.WriteLine("  7. Medical Goal");

        string goalOption = Console.ReadLine();

        Console.Write("Goal name (eg. Scripture Reading): ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description = Console.ReadLine();
        Console.Write("Goal duration (eg. 5hr, 5days): ");
        string duration = Console.ReadLine();

        switch (goalOption)
        {
            case "1":
                // Physical Activity
                Console.Write("What's the intensity of the exercise (eg. advance): ");
                string intensity = Console.ReadLine();

                PhysicalActivity physicalActivity = new PhysicalActivity(name, description, duration, false, intensity);
                wellnessTracker.AddActivity(physicalActivity);

                break;

            case "2":
                // Mental Activity
                MentalActivity mentalActivity = new MentalActivity(name, description, duration, false);
                wellnessTracker.AddActivity(mentalActivity);
                break;

            case "3":
                // Social Activity
                Console.Write("Group Size: ");
                String groupSize = Console.ReadLine();
                SocialActivity socialActivity = new SocialActivity(name, description, duration, false, groupSize);
                wellnessTracker.AddActivity(socialActivity);
                break;

            case "4":
                // Sleep and Relaxation Activity
                Console.Write("Sacrade text: ");
                String sacradeText = Console.ReadLine();
                SpiritualActivity spiritualActivity = new SpiritualActivity(name, description, duration, false, sacradeText);
                wellnessTracker.AddActivity(spiritualActivity);
                break;

            case "5":
                // Spiritual Activity
                Console.Write("Sacrade text: ");
                SleepAndRelaxationActivity sleepAndRelaxationActivity = new SleepAndRelaxationActivity(name, description, duration, false);
                wellnessTracker.AddActivity(sleepAndRelaxationActivity);
                break;

            case "6":
                // Nutrition Activity
                Console.Write("Nutrients ( eg. \"vitamins, fibre, protiens\"): ");
                String nutrients = Console.ReadLine();
                NutritionActivity nutritionActivity = new NutritionActivity(name, description, duration, false, nutrients);
                wellnessTracker.AddActivity(nutritionActivity);
                break;

            case "7":
                // Medical Activity
                Console.Write("Time ( eg. 1pm: ");
                String time = Console.ReadLine();
                MedicalActivity medicalActivity = new MedicalActivity(name, description, duration, false, time);
                wellnessTracker.AddActivity(medicalActivity);
                break;

            default:
                break;
        }
    }

    public void CompleteActivity(){
        Console.WriteLine("Your current welness progress are is:");
        wellnessTracker.DisplayProgress();

        Console.WriteLine();
        Console.Write("Which activity do you want to mark complete (eg. 1): ");
        int activityIndex = int.Parse(Console.ReadLine());

        wellnessTracker.MarkComplete(activityIndex-1);
    }

    public void TrackProgress(){
        Console.WriteLine("Your current welness progress are is:");
        wellnessTracker.DisplayProgress();
        Console.WriteLine();
    }

    public void DisplaySingleActivityGoal(){
        this.wellnessTracker.DisplayActivityGoal();
    }
    
}