using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for first name and store in a firstName variable.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt for last name and store it in a lastName variable
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine();

        // Display the User's name on the screen
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}