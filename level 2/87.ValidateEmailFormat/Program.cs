//Program to Validate Email Format

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "example@gmail.com";

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (Regex.IsMatch(email, pattern))
            Console.WriteLine("Valid Email Format");
        else
            Console.WriteLine("Invalid Email Format");
    }
}