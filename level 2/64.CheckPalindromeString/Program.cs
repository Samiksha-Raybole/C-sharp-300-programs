using System;

class PalindromeString
{
    static void Main()
    {
        Console.Write("Enter a string:");
        string str = Console.ReadLine();
        string reverse = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse += str[i];
        }
        if(str == reverse)
        Console.WriteLine("The string is a Palindrome.");
        else
        Console.WriteLine("string is not a Palindrome.");
        
    }
}