using System;

/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab9A
*/
class Lab9A
{
    static void Main(string[] args)
    {
        int size = 10;
        int[] numbers = new int[size];

        Console.WriteLine("Please enter 10 numbers:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Integer {i+1}: ");

            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nWhat is the target number: ");
        int search = Convert.ToInt32(Console.ReadLine());

        int position = LinearSearch(numbers, search);
        if (position != -1)
        {
            Console.WriteLine($"\nThe target is in the set.");
        }
        else
        {
            Console.WriteLine($"\nThe target is not in the set.");
        }
    }

    static int LinearSearch(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
}

