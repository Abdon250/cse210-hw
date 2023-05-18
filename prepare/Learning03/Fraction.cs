using System;


public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int Top, int Bottom)
    {
        _top = Top;
        _bottom = Bottom;
    }
    
    public string getFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double getDecimalNumber()
    {
        return (double)_top/(double)_bottom;
        
    }
}