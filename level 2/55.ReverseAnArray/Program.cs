using System;

class ReverseArray
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        Array.Reverse(arr);

        Console.WriteLine("Reversed Array:");

        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}