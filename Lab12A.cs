using System;
/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab12A
*/
public class chair
{
    public int numLegs;
    public bool rolling;
    public string material;


    public chair(int legs, bool roll, string mat)
    {
        numLegs = legs;
        rolling = roll;
        material = mat;
    }
}

public class Lab12A
{
    public static void Main(string[] args)
    {
        Console.WriteLine("You are about to create a chair.");

        Console.Write("How many legs does your chair have: ");
        int legs = Convert.ToInt32(Console.ReadLine());

        Console.Write("Is your chair rolling (true/false): ");
        bool roll = Convert.ToBoolean(Console.ReadLine());

        Console.Write("What is your chair made of: ");
        string material = Console.ReadLine();

        chair myChair = new chair(legs, roll, material);

        Console.WriteLine($"\nYour chair has {legs} legs, is {(roll ? "rolling" : "not rolling")}, and is made of {material}.");

        Console.WriteLine("\nThis program is going to change that.\n");
        myChair.numLegs = 4;
        myChair.rolling = false;
        myChair.material = "wood";

        Console.WriteLine($"Your chair has {myChair.numLegs} legs, is {(myChair.rolling ? "rolling" : "not rolling")}, and is made of {myChair.material}.");

    }
}

