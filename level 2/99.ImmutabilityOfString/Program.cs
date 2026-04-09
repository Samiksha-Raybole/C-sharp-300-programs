//Program to Demonstrate Immutability of Strings

using System;

class Program
{
    static void Main()
    {
        string str = "Hello";
        Console.WriteLine("Original String: " + str);

        str = str + " World";

        Console.WriteLine("Modified String: " + str);
    }
}