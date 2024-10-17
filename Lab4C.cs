/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab4C
*/
using System;

class Lab4C
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        Console.Write("Please input a number: ");
        float numbers = float.Parse(Console.ReadLine());

        Console.WriteLine("\nWhat would you like to do to this number:");
        Console.WriteLine("0) Get the additive inverse of the number");
        Console.WriteLine("1) Get the reciprocal of the number");
        Console.WriteLine("2) Square the number");
        Console.WriteLine("3) Cube the number");
        Console.WriteLine("4) Exit the program");
        short program = Convert.ToInt16(Console.ReadLine());


        switch (program)
        {
            case 0:
                
                float adInv = (float)(numbers * -1.0);
                Console.WriteLine($"The additive inverse of {numbers} is {adInv}");
            break;
             
            case 1:
                
                float reciprocal = (float)Math.Pow(numbers, -1.0);
                Console.WriteLine($"The reciprocal of {numbers} is {reciprocal}");
            break;

                
            case 2:
                
                float square = (float)Math.Pow(numbers, 2.0);
                Console.WriteLine($"The square of {numbers}.0 is {square}.0");
            break;
                
            case 3:
                
                float cube = (float)Math.Pow(numbers, 3.0);
                Console.WriteLine($"The cube of {numbers}.0 is {cube}.0");
            break;
                
            case 4:
                Console.WriteLine("Thank you, goodbye!");
            break;

            default:
                Console.WriteLine("Invalid input, please try again!");
            break;

        }
    }
}

