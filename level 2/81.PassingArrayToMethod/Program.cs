//Program to Demonstrate Passing Array to Method

using System;

class Program
{
    static void DisplayArray(int[] arr)
    {
        Console.WriteLine("Array Elements:");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }

    static void Main()
    {
        int[] numbers = {10, 20, 30, 40, 50};
        DisplayArray(numbers);
    }
}