using System;

class Program
{
    static void Main(string[] args)
    {
        
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            // Create an instance of an random generator,
            // and generate an random number.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int userGuess = 0; // What the user guessed
            int count = 0; // Count of user guesses.
            do
            {

                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                userGuess = int.Parse(guess);

                count++;

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {count} guess to guessed it right.");

                    Console.WriteLine();

                    Console.Write("Do you want to play again? (yes or  no) ");

                    playAgain  = Console.ReadLine(); // Ask the user if they want to play again.
                    
                }
            } while (userGuess != magicNumber);
        }
        


    }
}