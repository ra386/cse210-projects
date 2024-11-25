using System;

public class Fraction
{
    private int _top;
    private int _buttom;

    public Fraction()
    {
        _top = 1;
        _buttom = 1;
    }

    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _buttom = 1;

    }

    public Fraction (int top, int buttom)
    {
        _top = top;
        _buttom = buttom;

    }
}