//Program to Find Frequency of Characters in a String
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int[] count = new int[256];

        foreach (char c in str)
        {
            count[c]++;
        }

        Console.WriteLine("Character Frequencies:");

        foreach (char c in str)
        {
            if (count[c] != 0)
            {
                Console.WriteLine(c + " : " + count[c]);
                count[c] = 0;
            }
        }
    }
}