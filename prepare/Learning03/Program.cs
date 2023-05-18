using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction F1 = new Fraction();
        Console.WriteLine(F1.getFractionString());
        Console.WriteLine(F1.getDecimalNumber());

        Fraction F2 = new Fraction(5);
        Console.WriteLine(F2.getFractionString());
        Console.WriteLine(F2.getDecimalNumber());
        
        Fraction F3 = new Fraction(3,4);
        Console.WriteLine(F3.getFractionString());
        Console.WriteLine(F3.getDecimalNumber());

        Fraction F4 = new Fraction(1,3);
        Console.WriteLine(F4.getFractionString());
        Console.WriteLine(F4.getDecimalNumber());
        
    }
    
}