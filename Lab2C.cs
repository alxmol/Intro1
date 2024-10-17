/* 
Class: CSE 1321L 
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab2C
*/
using System;

class Lab2C
{
    static void Main(string[] args)
    {
        Console.Write("Enter a width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter a height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine($"The area is {area}");
        Console.WriteLine($"The perimeter is {perimeter}");
    }
}