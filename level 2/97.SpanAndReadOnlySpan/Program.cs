//Program to Demonstrate Span and ReadOnlySpan

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Span<int> span = numbers.AsSpan(1, 3); // elements from index 1
        Console.WriteLine("Span Elements:");

        foreach (var n in span)
        {
            Console.WriteLine(n);
        }

        ReadOnlySpan<int> readOnlySpan = numbers;

        Console.WriteLine("ReadOnlySpan Elements:");
        foreach (var n in readOnlySpan)
        {
            Console.WriteLine(n);
        }
    }
}