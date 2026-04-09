//Program to Demonstrate Regular Expressions

using System;
using System.Text.RegularExpressions;

class RegexDemo
{
    static void Main()
    {
        string text = "Welcome to CSharp Programming";

        string pattern = "CSharp";

        if (Regex.IsMatch(text, pattern))
        {
            Console.WriteLine("Pattern found in the string");
        }
        else
        {
            Console.WriteLine("Pattern not found");
        }
    }
}