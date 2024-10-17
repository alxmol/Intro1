/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab11A
*/

using System;

class Lab11A
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\nMenu");
            Console.WriteLine("0) Hello World\n1) Goodbye Moon\n2) Walking on Sunshine\n");
            Console.Write("What would you like to do: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("\nHello!\n");
                    break;
                case 1:
                    Console.WriteLine("\nOk, bye.\n");
                    break;
                case 2:
                    Console.WriteLine("\nWHOA!\n");
                    break;
                default:
                    Console.WriteLine("\nEnter a valid menu choice.\n");
                    break;
            }
            Console.Write("Type YES to rerun. ");
            string input = Console.ReadLine();
            if (!string.Equals(input, "YES", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nProgram Ends");
                break;
            }
        }
    }
}

