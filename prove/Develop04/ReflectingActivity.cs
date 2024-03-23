class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> _questionsIndex;
    
    public ReflectingActivity(string name, string description) : base(name, description){
        this._prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];

        this._questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
        this._questionsIndex = new List<int>();
        for (int index = 0; index < _questions.Count; index++)
        {
            this._questionsIndex.Add(index);
        }
    }

    private string GetRandomPrompt(){
        Random randomNumber = new Random();

        int randomPromptIndex = randomNumber.Next(this._prompts.Count);

        return this._prompts[randomPromptIndex];
    }

    private string GetRandomQuestion(){
        Random randomNumber = new Random();

        // Randomly select a question onces (Don't repeat a question)
        // Until all questions have been asked at least once in a session.
        if (this._questionsIndex.Count == 0)
        {
            for (int index = 0; index < _questions.Count; index++)
            {
                this._questionsIndex.Add(index);
            }
        }
        int randomQuestionIndex = randomNumber.Next(this._questionsIndex.Count);


        string question = this._questions[this._questionsIndex[randomQuestionIndex]];

        this._questionsIndex.RemoveAt(randomQuestionIndex);

        return question;
    }

    private void DisplayPrompt(){
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {this.GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder each of the following qduestions as they relate to this experience.");
        Console.Write("You may begin in: ");
        this.ShowCountdown(5);
    }

    private void DisplayQuestions(){
        DateTime end = DateTime.Now.AddSeconds(this._duration);

        while (DateTime.Now < end)
        {
            Console.Write($"> {this.GetRandomQuestion()} ");
            this.DisplaySpinner(5);
            Console.WriteLine();
        }
    }

    public void Run(){
        this.DisplayStartingMessage();

        this.DisplayPrompt();

        Console.WriteLine();

        this.DisplayQuestions();

        Console.WriteLine();

        this.DisplayEndingMessage();
    }
}