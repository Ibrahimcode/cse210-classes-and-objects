using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
         string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int squareNumber = SquareNumber(favNum);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
       Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string userName, int num)
    {
        Console.WriteLine($"{userName}, the square of your number is {num}");
    }
}

