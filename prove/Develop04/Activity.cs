class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description){
        this._name = name;
        this._description = description;
        this._duration = 0;
    }

    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {this._name} activity");
        Console.WriteLine();
        Console.WriteLine(this._description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        this._duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");
        Console.WriteLine();

        this.DisplaySpinner(5);
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("Well done!!");
        this.DisplaySpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You've completed another {this._duration} seconds of {this._name} activity");
        this.DisplaySpinner(4);

        Console.WriteLine();
    }

    public void DisplaySpinner(int seconds){
        
        List<string> spinnerCords = ["|","/","—","\\","|"];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        foreach (string cord in spinnerCords)
        {
            Console.Write(cord);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            if (DateTime.Now >= endTime)
            {
                return;
            }  
        }
     }

    public void ShowCountdown(int seconds){
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        for (int sec = seconds; sec > 0; sec--)
        {
            Console.Write(sec);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}