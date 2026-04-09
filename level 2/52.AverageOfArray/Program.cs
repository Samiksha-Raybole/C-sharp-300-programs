using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        int sum = 0;
        double average;

        Console.WriteLine("Enter 5 elements:");

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        average = sum / (double)arr.Length;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }
}