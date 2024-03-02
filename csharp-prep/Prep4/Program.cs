using System;

class Program
{
    static void Main(string[] args)
    {
        // stores the numbers enter by the  user.
        List<int> userNums = new List<int>(); 
        int userInput;
        bool stop = false; // to the loop when the user enter 0.
       // True when the user enter a negative number 
       // (helps to avoid errors in finding the smallest number enter by the user)
       // if the list contains negative number(s).
        bool negativeNum = false; 
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

       

        while (!stop)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                userNums.Add(userInput);
                if (userInput  < 0 && negativeNum == false)
                {
                    negativeNum = true;
                }
            }else
            {
                stop = true;
            }
        }

        double ave = userNums.Average();
        int total = userNums.Sum();
        int max = userNums.Max();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {max}");


        userNums.Sort();

        if (negativeNum)
        {
            // Finding the smallest number if the list contains negative numbers
            int smallestNum = userNums.Where(x => x > 0).Min();
            Console.WriteLine($"The smallest positive number is: {smallestNum}");
        }else
        {
            // When the list does not contain negative number.
            int smallestNum = userNums.Min();
            Console.WriteLine($"The smallest positive number is: {smallestNum}");
        }

        Console.WriteLine("The sorted list is:");
        foreach (var item in userNums)
        {
            Console.WriteLine(item);
        }
        
    }
}