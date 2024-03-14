using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Default Constructon: _top = 1; _bottom = 1;
        Fraction frac1 = new Fraction();

        // Second Constructon: _top = 5; _bottom = 1;
        Fraction frac2 = new Fraction(5);

        // Third Constructon: _top = 3; _bottom = 4;
        Fraction frac3 = new Fraction(3, 4);

        // Default Constructon: _top = 1; _bottom = 1;
        Fraction frac4 = new Fraction();
        frac4.SetBottom(3);

        Console.WriteLine(frac1.GetDecimalValue());
        Console.WriteLine(frac2.GetDecimalValue());
        Console.WriteLine(frac3.GetDecimalValue());
        Console.WriteLine(frac4.GetDecimalValue());
    }
}