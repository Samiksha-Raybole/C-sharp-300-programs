using System;

class CountWords
{
    static void Main()
    {
        Console.Write("Enter a sentence:");
        string str = Console.ReadLine();

        string[] words = str.Split(' ');
        int count = words.Length;

        Console.WriteLine("Number of words:" +count);
    }
}