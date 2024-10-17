/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab3A
*/
using System;


class Lab3A
{
    static void Main(string[] args)
    {
        Console.Write("Amount owed: $");
        float amount = float.Parse(Console.ReadLine());
        Console.Write("Apr: ");
        float apr = float.Parse(Console.ReadLine());

        float mpr = apr / 12;
        float monthly = (amount * (apr / 100)) / 12;
        Console.WriteLine($"Monthly percentage rate: {mpr.ToString("n3")}");
        Console.WriteLine($"Minimum payment: ${monthly.ToString("n2")}");
    }
}