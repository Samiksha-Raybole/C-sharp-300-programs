//Program to Find Duplicate Elements in Array

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 3 };

        Console.WriteLine("Duplicate Elements:");

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine(arr[j]);
                }
            }
        }
    }
}