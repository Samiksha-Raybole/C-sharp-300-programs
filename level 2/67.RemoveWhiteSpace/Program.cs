//Program to Remove White Spaces from String
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string result = "";

        foreach (char c in str)
        {
            if (c != ' ')
            {
                result += c;
            }
        }

        Console.WriteLine("String without spaces: " + result);
    }
}