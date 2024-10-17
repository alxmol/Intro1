/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab4A
*/
using System;

class Lab4A
{
    static void Main(string[] args)
    {
        string[] letterGrades = { "F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A", "A+" };


        Console.Write("Enter the score of your exam: ");
        double score = Convert.ToDouble(Console.ReadLine());

   
        int index;
        if (score >= 97.5)
            index = 12;
        else if (score >= 94.5)
            index = 11;
        else if (score >= 91.5)
            index = 10;
        else if (score >= 88.5)
            index = 9;
        else if (score >= 85.5)
            index = 8;
        else if (score >= 82.5)
            index = 7;
        else if (score >= 79.5)
            index = 6;
        else if (score >= 76.5)
            index = 5;
        else if (score >= 73.5)
            index = 4;
        else if (score >= 70.5)
            index = 3;
        else if (score >= 67.5)
            index = 2;
        else if (score >= 64.5)
            index = 1;
        else
            index = 0;
        int indice = index;

        string printedGrade = letterGrades[indice];

        Console.WriteLine($"Letter grade is: {printedGrade}");
    }
}

