/* Online C# Compiler and Editor */
using System.IO;
using System;

class Student
{
    public int[] marks = {40, 60, 50, 70, 80};
    public double average()
    {
        int count = 0;
        for(int i = 0; i < marks.Length; i++)
        {
            count += marks[i];
        }
        
        return count/ marks.Length;
    }
    
    
}

class Program
{
    
    static void Main()
    {
        Student s = new Student();
        Console.WriteLine($"Average: {s.average()}");

        
        
        
    }
}
