/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment3C
*/
using System;
class Assignment3C
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello stranger! Do you have time to hear my tale?");
        Console.WriteLine("1) Yes\n2) No");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Thank you! I come from the land of Pax Bisonica. Our country has been taken over by a cruel tyrant!");
            Console.WriteLine("1) That's awful!\n2) What can I do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Alas, it is truly terrible...");
                Console.WriteLine("Please, you must journey to Pax Bisonica and free our country!");
                Console.WriteLine("1) No\n2) Okay");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Then all is lost...");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Hooray!");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Please, you must journey to Pax Bisonica and free our country!");
                Console.WriteLine("1) No\n2) Okay");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Then all is lost...");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Hooray!");
                }
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Ah, then goodbye...");
        }
    }
}