using System;

class Program
{
    static void Main(string[] args)
    {
         Journal journal = new Journal();
         PromptGenerator promptGenerator = new PromptGenerator();

        string action = "";

        while (action != "5")
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What whould you like to do? ");
            action = Console.ReadLine();

            if (action == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string promptEntry = Console.ReadLine();

                DateTime currentDate =  DateTime.Now;
                EntryData entryData = new EntryData{
                    date = currentDate.ToShortDateString(),
                    promptText = prompt,
                    entryText = promptEntry
                };

                journal.AddEntry(new Entry(entryData));
            }else if (action == "2")
            {
                journal.DisplayAll();
            }else if (action == "3")
            {
                Console.WriteLine("What is the json file name?");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }else if (action == "4")
            {
                Console.WriteLine("What is the json file name?");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }else
            {
                action = "5";
            }
            Console.WriteLine();
        }
    }
}