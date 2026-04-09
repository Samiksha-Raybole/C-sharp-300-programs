//Program to Remove Special Characters from String

using System;

class Program
{
    static void Main()
    {
        string str = "Hello@123#World!";
        string result = "";

        foreach (char c in str)
        {
            if (char.IsLetterOrDigit(c) || c == ' ')
                result += c;
        }

        Console.WriteLine("After removing special characters: " + result);
    }
}