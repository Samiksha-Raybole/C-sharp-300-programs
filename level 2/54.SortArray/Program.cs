using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 1, 3 };

        Array.Sort(arr);

        Console.WriteLine("Sorted Array Elements:");

        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}