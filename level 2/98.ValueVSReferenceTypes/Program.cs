//Program to Demonstrate Value vs Reference Types

using System;

class Program
{
    static void Main()
    {
        // Value type example
        int a = 10;
        int b = a;
        b = 20;

        Console.WriteLine("Value Type:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        // Reference type example
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        arr2[0] = 100;

        Console.WriteLine("Reference Type:");
        Console.WriteLine("arr1[0] = " + arr1[0]);
        Console.WriteLine("arr2[0] = " + arr2[0]);
    }
}