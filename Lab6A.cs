/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab6A
*/

using System;
class Lab6A
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 10 numbers and this program will display the largest.\n");
        int largest = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Please enter number {i}: ");
            int largest1 = Convert.ToInt32(Console.ReadLine());

            if (largest1 > largest)
            {
                largest = largest1;
            }
        }

        Console.WriteLine($"\nThe largest number was {largest}");
    }
}

