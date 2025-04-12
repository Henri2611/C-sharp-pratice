/* Online C# Compiler and Editor */
using System.IO;
using System;

class Program
{
    public int CountVowels(string y){
        string vowels = "AEIOUaeiou";
        int count = 0;
        
        for(int i = 0; i < y.Length; i++)
        {
            if(vowels.Contains(y[i]))
            {
                count++;
                
            }
        }
        return count;
    }
    static void Main()
    {
        
        Program p = new Program();
        Console.Write("Enter a word:\n");
        string wrd = Console.ReadLine();
        Console.WriteLine("Number of vowels: " + p.CountVowels(wrd));
        
        
    }
}
