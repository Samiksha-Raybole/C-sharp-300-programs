using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.Write("Enter substring to replace: ");
        string oldSub = Console.ReadLine();

        Console.Write("Enter new substring: ");
        string newSub = Console.ReadLine();

        string result = str.Replace(oldSub, newSub);

        Console.WriteLine("Updated String: " + result);
    }
}