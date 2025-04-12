using System;

class Rectangle
{
    public int Length;
    public int Width;

    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }

    public int Area()
    {
        return Length * Width;
    }

    public int Perimeter()
    {
        return 2 * (Length + Width); 
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(4, 3);
        Console.WriteLine("Area: " + rectangle.Area());
        Console.WriteLine("Perimeter: " + rectangle.Perimeter());
    }
}
