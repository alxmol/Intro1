/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab5C
*/
using System;

class Lab5C
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());


        if (x == 0)
        {
            if (y == 0)
            {
                Console.WriteLine("This point is the origin.");
            }
            else
            {
                Console.WriteLine("This point is on the y axis.");
            }
        }
        else if (x != 0)
        {
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("This point is in the first quadrant.");
                }
                else if (y < 0)
                {
                    Console.WriteLine("This point is in the fourth quadrant.");
                }
                else
                {
                    Console.WriteLine("This point is on the x axis.");
                }
            }
            if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("This point is in the second quadrant.");
                }
                else if (y < 0)
                {
                    Console.WriteLine("This point is in the third quadrant.");
                }
                else
                {
                    Console.WriteLine("This point is on the x axis.");
                }
            }

        }
    }
}

