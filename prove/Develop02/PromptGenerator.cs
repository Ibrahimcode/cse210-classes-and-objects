class PromptGenerator
{
    // Suggested prompts for users to write about.
    List<String> _prompts = new List<String>{
        "What was the best part of my day",
        "If I had one thing I could do over tody, what would it be?",
        "Who was the most interesting person I interact with today?"
    };

    // hold any promps that the user has answered
    List<String> _usedPrompts = new List<String>();

    // Generate a unique random prompt for the user.
    public String GetRandomPrompt()
    {   
        Random randomGeneratory = new Random();
        int promptIndex = randomGeneratory.Next(0, this._prompts.Count);
        String prompt = _prompts[promptIndex];

        if (this._prompts.Count == this._usedPrompts.Count)
        {
            return "";
        }

        // Make sure each prompt question is ask only once.
        if (this._usedPrompts.Contains(prompt))
        {
            GetRandomPrompt();
        }

        return prompt;
    }
}