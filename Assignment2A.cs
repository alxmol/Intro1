/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment2A
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

class Assignment2A
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number you want to find a multiple of: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int remainder = n2 % n1;
        int multiple;

        if (remainder == 0)
        {
            multiple = n2;
        }
        else
        {
            int lowerMultiple = n2 - remainder;
            int higherMultiple = lowerMultiple + n1;
            multiple = (n2 - lowerMultiple) <= (higherMultiple - n2) ? lowerMultiple : higherMultiple;
        }
        Console.WriteLine($"Calculating...\nThe nearest multiple of {n1} from {n2} is {multiple}!");

    }
}

