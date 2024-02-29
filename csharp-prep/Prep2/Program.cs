using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt students for their grade percentage.
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        double percentage = double.Parse(gradePercentage); // Conver to double

        string gradeLetter = ""; // Will hold the grade lette (A, B, C ...)

        // Round the percentage and cast it to and int then find the extract the last digit.
        int lastDigit = (int)Math.Round(percentage) % 10;

        string gradeSign = ""; // Will hold the grade sign (+, -)

        // Will not display sign for "F" and "A+";
        if (percentage >= 60 & percentage < 93)
        {
            if (lastDigit >= 7)
            {
                gradeSign = "+";
            }else if (lastDigit < 3)
            {
                gradeSign = "-";
            }else
            {
                gradeSign = "";
            }
            
        }

        // Determine the grade letter.
        if (percentage >= 90)
        {
            gradeLetter = "A";
        }else if (percentage >= 80)
        {
            gradeLetter = "B";
        }else if(percentage >= 70)
        {
            gradeLetter = "C";
        }else if (percentage >= 60)
        {
            gradeLetter = "D";
        }else
        {
            gradeLetter = "F";
        }

        // Output the grade letter and sign.
        Console.WriteLine($"Your letter grade is {gradeLetter}{gradeSign}");

        if (percentage >= 70)
        {
            Console.WriteLine($"Congratulations! you pass with a grade of {percentage}%");
        }else
        {
            Console.WriteLine("You efforts counts a lot, please take this course again.");
        }
    }
}