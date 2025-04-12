using System;

class Program
{
    public int LargestNumber(int[] arr)
    {
        int max = arr[0];
        for (int x = 1; x < arr.Length; x++)
        {
            if (arr[x] > max)
            {
                max = arr[x];
            }
        }
        return max;
    }

    static void Main()
    {
        Program p = new Program();
        int[] myNum = { 10, 20, 30, 40 };
        Console.WriteLine("Largest number: " + p.LargestNumber(myNum));
    }
}
