//Program to Demonstrate params Keyword

using System;

class Program
{
    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }

    static void Main()
    {
        Console.WriteLine("Sum of numbers: " + Sum(10, 20, 30));
        Console.WriteLine("Sum of numbers: " + Sum(5, 15));
    }
}