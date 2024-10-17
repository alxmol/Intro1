/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab3C
*/
using System;


class Lab3C
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of quarters: ");
        int quarters = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of dimes: ");
        int dimes = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of nickels: ");
        int nickels = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of pennies: ");
        int pennies = int.Parse(Console.ReadLine());

        int total = pennies + (5 * nickels) + (10 * dimes) + (25 * quarters);


        Console.WriteLine($"\nYou entered {quarters} quarters.");
        Console.WriteLine($"You entered {dimes} dimes.");
        Console.WriteLine($"You entered {nickels} nickels.");
        Console.WriteLine($"You entered {pennies} pennies.");
        Console.WriteLine($"\nYour total is {total / 100} dollars and {total % 100} cents.");
    }
}

