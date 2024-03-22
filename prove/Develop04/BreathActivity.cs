class BreathActivity : Activity
{
    public BreathActivity(string name,  string description) : base(name, description){

    }

    public void  Run(){
        // Beep two times before starting.
        this.DisplayStartingMessage();
        Console.Beep();
        Thread.Sleep(500);
        Console.Beep();

        DateTime endTime = DateTime.Now.AddSeconds(this._duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            this.ShowCountdown(5);
            Console.WriteLine();
            Console.Write("Breath out...");
            this.ShowCountdown(4);
            Console.WriteLine();
            Console.WriteLine();
        }

        this.DisplayEndingMessage();
    }
}