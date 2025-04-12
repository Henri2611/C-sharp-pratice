using System;

class Program
{
    static void Main()
    {
        int result = 1;
        for (int x = 5; x > 0; x--)
        {
            result *= x;
        }

        Console.WriteLine("Factorial of 5 is: " + result);
    }
}
