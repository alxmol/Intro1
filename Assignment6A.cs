/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment6A
*/


using System;

class Assignment6A
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("[Bogosort]\n");

        int[] array = new int[19];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 454);
        }

        int attempt = 0;
        while (!check_if_sorted(array))
        {
            PrintArray(array);
            Console.WriteLine("Not sorted yet!\n\nShuffling array...\n");
            array = shuffleArray(array);
            attempt++;
        }

        PrintArray(array);
        Console.WriteLine($"Hooray, it's sorted! And it only took {attempt} attempts!");
    }

    static bool check_if_sorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    static int[] shuffleArray(int[] array)
    {
        int[] newArray = (int[])array.Clone();
        for (int i = newArray.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            int temp = newArray[i];
            newArray[i] = newArray[j];
            newArray[j] = temp;
        }
        return newArray;
    }

    static void PrintArray(int[] array)
    {
        Console.Write("Printing array...\n");
        foreach (int value in array)
        {
            Console.Write(value + ", ");
        }
        Console.WriteLine();
    }
}

