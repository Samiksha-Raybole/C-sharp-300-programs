//Program to Find Missing Number in Array

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 5 }; // Missing number is 4
        int n = 5;

        int sum = n * (n + 1) / 2;
        int arraySum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arraySum += arr[i];
        }

        int missingNumber = sum - arraySum;

        Console.WriteLine("Missing Number: " + missingNumber);
    }
}