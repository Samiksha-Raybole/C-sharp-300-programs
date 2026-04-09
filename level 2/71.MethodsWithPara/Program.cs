//Program to Demonstrate Methods with Parameters

using System;

class Program
{
    static void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    static void Main()
    {
        Add(10, 20);
    }
}