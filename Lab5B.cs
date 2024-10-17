/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab5B
*/
using System;

class Lab5B
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int integer = Convert.ToInt32(Console.ReadLine());

        int divisible = 0;
        if (integer % 2 == 0) divisible = 2;
        else if (integer % 3 == 0) divisible = 3;
        else if (integer % 5 == 0) divisible = 5;

        switch (divisible)
        {
            case 2:
                Console.WriteLine("This number is divisible by 2");
                break;
            case 3:
                Console.WriteLine("This number is divisible by 3");
                break;
            case 5:
                Console.WriteLine("This number is divisible by 5");
                break;
            default:
                Console.WriteLine("This number is undetermined");
                break;
        }
    }
}


