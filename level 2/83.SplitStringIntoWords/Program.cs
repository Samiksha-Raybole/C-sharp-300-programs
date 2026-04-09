//Program to Split String into Words

using System;

class Program
{
    static void Main()
    {
        string sentence = "C sharp programming language";
        string[] words = sentence.Split(' ');

        Console.WriteLine("Words in the string:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}