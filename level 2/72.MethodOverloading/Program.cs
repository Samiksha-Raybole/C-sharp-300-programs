//Program to Demonstrate Method Overloading

using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main()
    {
        Console.WriteLine("Sum of two numbers: " + Add(10, 20));
        Console.WriteLine("Sum of three numbers: " + Add(10, 20, 30));
    }
}