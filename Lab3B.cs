/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab3B
*/
using System;


class Lab3B
{
    static void Main(string[] args)
    {
        Console.Write("Course 1 hours: ");
        int c1_h = int.Parse(Console.ReadLine());
        Console.Write("Grade for course 1: ");
        int c1_g = int.Parse(Console.ReadLine());
        Console.Write("Course 2 hours: ");
        int c2_h = int.Parse(Console.ReadLine());
        Console.Write("Grade for course 2: ");
        int c2_g = int.Parse(Console.ReadLine());
        Console.Write("Course 3 hours: ");
        int c3_h = int.Parse(Console.ReadLine());
        Console.Write("Grade for course 3: ");
        int c3_g = int.Parse(Console.ReadLine());
        Console.Write("Course 4 hours: ");
        int c4_h = int.Parse(Console.ReadLine());
        Console.Write("Grade for course 4: ");
        int c4_g = int.Parse(Console.ReadLine());

        float totalHours = c1_h + c2_h + c3_h + c4_h;
        float totalQualityPts = (c1_h * c1_g) + (c2_h * c2_g) + (c3_g * c3_h) + (c4_g * c4_h);
        double gpa = (double) totalQualityPts / totalHours;

        double stringGpa = truncateGpa(gpa, 6);

        Console.WriteLine($"Total hours is: {totalHours}");
        Console.WriteLine($"Total quality points is: {totalQualityPts}");
        Console.WriteLine($"Your GPA for this semester is {stringGpa}");

    }


    static double truncateGpa(double gpa, int decimalPlaces)
    {//In math.pow, first number (10) is the base number, and it is multiplied by the next variable
    //which in this case is 6, so decimalMult becomes one million. Gpa variable is then multiplied
    //by a million to move the value 6 places to the right, so for example, a gpa of 1.9191919 becomes
    //1919191.9, the value is then truncated (its math.truncate, so value rounds down, so the .9 becomes
    //.0, or a whole number, and then once again divided by decimalMult to go back to its original value
    //but all truncated and also rounded down.
        double decimalMult = Math.Pow(10, decimalPlaces);
        return Math.Truncate(gpa * decimalMult) / decimalMult;
    }
}
