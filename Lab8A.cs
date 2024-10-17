using System;

/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab8A
*/
class Lab8A
{
    static void Main(string[] args)
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];
        int[] sumsArray = new int[5];

        Console.WriteLine("Please enter 5 integers for the first array:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Integer {i + 1}: ");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Please enter 5 integers for the second array:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Integer {i + 1}: ");
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            sumsArray[i] = array1[i] + array2[i];
        }

        Console.WriteLine("The resulting sums are ");
        foreach (int val in sumsArray)
        {
            Console.Write($"{val}|");
        }
    }
}