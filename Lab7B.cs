/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab7B
*/
using System;

class Lab7B
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a value for the size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"This is the requested {size}x{size} right-triangle: ");
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

