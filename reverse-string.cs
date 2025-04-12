
using System.IO;
using System;

class Program
{
    public string ReverseWord(string y){
        string results = "";
        for(int i = y.Length - 1; i >= 0; i--){
            results += y[i];
            
        }
        return results;
    }
    static void Main()
    {
        
        Program p = new Program();
        Console.Write("Enter a word:\n");
        string wrd = Console.ReadLine();
        Console.WriteLine(p.ReverseWord(wrd));
        
        
    }
}
