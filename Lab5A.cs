/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab5A
*/
using System;


class Lab5A
{
    static void Main(string[] args)
    {
        Console.Write("Do you have a driving permit (Y/N)?");
        string permInput_1 = Console.ReadLine();
        string permInput_2 = permInput_1.ToLower();


        if (permInput_2 == "y")
        {
            Console.Write("Do you have a commercial driving license (Y/N)?");
            string comInput_1 = Console.ReadLine();
            string comInput_2 = comInput_1.ToLower();
            if (comInput_2 == "y")
            {
                Console.WriteLine("Congratulations! You can purchase a vehicle, let's start talking options!");
            }
            else
            {
                Console.WriteLine("Commercial driving license is a prerequisite to purchase a vehicle!");
            }
        }
        else
        Console.WriteLine("Driving permit is a prerequisite to purchase a vehicle!");
    }
}

