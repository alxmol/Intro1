
using System;
/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: La9B
*/
class Lab9B
{
    static void Main(string[] args)
    {
        int size = 11;
        int[] numbers = new int[size];

        Console.WriteLine("Please enter 11 numbers:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Integer {i+1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.Write("\nWhat is the target number: ");
        int target = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nThe sorted set is: ");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int result = BinarySearch(numbers, target);

        if (result != -1)
            Console.WriteLine($"\nThe target is in the set.");
        else
            Console.WriteLine($"\nThe target is not in the set.");
    }
    static int BinarySearch(int[] arr, int x)
    {
        int l = 0, r = arr.Length - 1;

        while (l <= r)
        {
            int m = l + (r - l) / 2;

            Console.WriteLine($"\nLow is {l} \n\nHigh is {r} \n\nMid is {m} \n\nSearching");
            if (arr[m] == x)
                return m;

            if (arr[m] < x)
                l = m + 1;

            else
                r = m - 1;
        }
        return -1;
    }
}

