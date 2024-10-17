/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab11B
*/

using System;

class Lab11B
{
    static void Main(string[] args)
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        if (valid(password))
        {
            Console.WriteLine("Valid password");
            Console.WriteLine("\nProgram Ends");
        }
        else
        {
            Console.WriteLine("Invalid password");
            Console.WriteLine("\nProgram Ends");
        }
    }

    static bool valid(string password)
    {
        bool upperChar = false;
        bool hasInt = false;
        bool length = password.Length >= 8;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                upperChar = true;
            }

            if (char.IsDigit(c))
            {
                hasInt = true;
            }

            if (upperChar && hasInt)
            {
                break;
            }
        }

        return upperChar && hasInt && length;
    }
}

