/* 
Class: CSE 1321L 
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab2A
*/
using System;
class Lab2A
{
    static void Main(string[] args)
    {
        Console.Write("Enter a name: ");
        string name1 = Console.ReadLine();

        Console.Write("Enter another name: ");
        string name2 = Console.ReadLine();

        Console.Write("Enter a verb: ");
        string verb = Console.ReadLine();

        Console.Write("Enter an adverb: ");
        string adverb = Console.ReadLine();

        Console.WriteLine($"Once upon a time, there was a person named {name1} who had a child named \r\n{name2}. This child would {verb} {adverb} while singing to strangers.");
    }
}