//Program to Validate Password Strength

using System;
using System.Text.RegularExpressions;

class PasswordCheck
{
    static void Main()
    {
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$";

        if (Regex.IsMatch(password, pattern))
        {
            Console.WriteLine("Strong Password");
        }
        else
        {
            Console.WriteLine("Weak Password");
        }
    }
}