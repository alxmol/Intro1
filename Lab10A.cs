/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab10A
*/

using System;
class Lab10A
{
    static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Min is {min(x, y)}");
        Console.WriteLine($"Max is {max(x, y)}");
        Console.WriteLine($"Average is {average(x, y)}");
    }
    static int max(int x, int y)
    {
        return x > y ? x : y;
    }

    static int min(int x, int y)
    {
        return x < y ? x : y;
    }

    static double average(int x, int y)
    {
        return (x + y) / 2.0;
    }
}

