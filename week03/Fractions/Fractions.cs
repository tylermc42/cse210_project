using System;

//create fraction class
public class Fraction
{
    // variable or attributes
    private int _top;
    private int _bottom;

    //methods or constructors
    //constructor that has no parameters that initializes the number to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //has one parameter for the top and initializes the denominator to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    //has two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    
    //create Getters and Setters
    public int GetTopValue()
    {
        return _top;
    }
    public void SetTopValue(int top)
    {
        _top = top;
    }

    public int GetBottomValue()
    {
        return _bottom;
    }
    public void SetBottomValue(int bottom)
    {
        _bottom = bottom;
    }

    // methods to return the representations
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}