using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int search;

        Console.Write("Enter element to search: ");
        search = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == search)
            {
                Console.WriteLine("Element found at position: " + (i + 1));
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Element not found.");
        }
    }
}