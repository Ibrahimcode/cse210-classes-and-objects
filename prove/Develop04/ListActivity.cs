using System.Security.Cryptography;

class ListActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListActivity(string name, string description) : base(name, description){
        this._prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    private string GetRandomPrompt(){
        Random randomNumber = new Random();

        int randomPromptIndex = randomNumber.Next(this._prompts.Count);

        return this._prompts[randomPromptIndex];
    }

    private List<string> GetListFromUser(){
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = this.GetRandomPrompt();
        Console.WriteLine();

        Console.WriteLine($"--- {prompt} ---");

        Console.Write("You may begin in: ");
        this.ShowCountdown(4);
        Console.WriteLine();

        List<string> userAnswers = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(this._duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userAnswer = Console.ReadLine();
            userAnswers.Add(userAnswer);
            this._count++;
        }

        return userAnswers;
    }


    public void Run(){
        this.DisplayStartingMessage();

        List<string> userAnswers = this.GetListFromUser();

        Console.WriteLine($"You listed {this._count} times!");
        Console.WriteLine();

        this.DisplayEndingMessage();
    }


}