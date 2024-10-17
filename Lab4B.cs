/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab4B
*/
using System;

class Lab4B
{
    static void Main(string[] args)
    {
        string[] messages = { "I have class today!", "I should use this time to do my homework.", "It's Friday! Friday! Gotta get down on Friday!", "Try again." };

        Console.Write("Enter the day: ");
        string dayInput_1 = Console.ReadLine();
        string dayInput_2 = dayInput_1.ToLower();

        int index = -1;
        if (dayInput_2 == "monday")
            index = 0;
        else if (dayInput_2 == "tuesday")
            index = 1;
        else if (dayInput_2 == "wednesday")
            index = 0;
        else if (dayInput_2 == "thursday")
            index = 1;
        else if (dayInput_2 == "friday")
            index = 2;
        else if (dayInput_2 == "saturday")
            index = 1;
        else if (dayInput_2 == "sunday")
            index = 1;
        else
            index = 3;


        string message = messages[index];
        Console.WriteLine($"{message}");


    }
}

