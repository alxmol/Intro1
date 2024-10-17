/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab7A
*/
using System;

class Lab7A
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a value for the size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int size1 = size;

        Console.WriteLine($"This is the requested {size}x{size1} box: ");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

