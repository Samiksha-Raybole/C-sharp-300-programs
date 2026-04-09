//Program to Demonstrate Memory Management Basics

using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[1000];

        Console.WriteLine("Memory allocated for array.");

        // Garbage Collector
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Garbage Collection executed.");
    }
}