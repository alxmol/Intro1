/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab1C
*/
using System;
public class Lab1C
{
	public static void Main(String[] args)
	{
        int miles;
        double gallons, mpg;
        Console.Write("Enter the number of miles: ");
        miles = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the gallons of fuel used: ");
        gallons = Convert.ToInt32(Console.ReadLine());
        mpg = miles / gallons;
        Console.WriteLine("Miles Per Gallon: " + mpg);
    }
}

