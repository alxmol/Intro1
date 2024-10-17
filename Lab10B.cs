/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab10B
*/

using System;
class Lab10B
{
    static void Main(string[] args)
    {
        string program;

        do
        {
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            if (isValid(width, height))
            {
                Console.WriteLine("This is a valid rectangle");
                Console.WriteLine($"The area is: {area(width, height)}");
                Console.WriteLine($"The perimeter is: {perimeter(width, height)}");
            }
            else
            {
                Console.WriteLine("This is an invalid rectangle\n");
            }

            Console.Write("Do you want to enter another width and height (Y/N)? : ");
            program = Console.ReadLine();
            Console.WriteLine();

        } while (program == "Y");

        Console.WriteLine("Program Ends");
    }
    static bool isValid(double width, double height)
    {
        return width + height > 30;
    }

    static double area(double width, double height)
    {
        return width * height;
    }

    static double perimeter(double width, double height)
    {
        return 2 * (width + height);
    }
}

