using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowlendge him, and he shall direct thy path.";
        // 

        Reference reference = new Reference("Provide", 3, 5, 6);

        Scripture scripture = new Scripture(reference, scriptureText);


        bool quitMemorizer = false;
        Console.Clear();
        // Above the requirement: Allow the users to choose the amount of words
        // they want to hide as the try to memorize the scripture.
        Console.WriteLine("How many word(s) do you want to be hiding: ");
        int amountOfWordToHide = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine(scripture.GetDisplay());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        while (!quitMemorizer)
        {
            Console.WriteLine();
            string memoryChoice = Console.ReadLine();

            if (memoryChoice == "")
            {
                Console.Clear();
                scripture.HideRandomWords(amountOfWordToHide);
                quitMemorizer = scripture.IsCompletelyHidden();
                Console.WriteLine(scripture.GetDisplay());
            }else
            {
                quitMemorizer = true;
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
        }
    }
}