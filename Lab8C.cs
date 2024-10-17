using System;
/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab8C
*/
class Lab8C
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the number of columns: ");
        int colms = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, colms];
        int currentValue = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colms; j++)
            {
                array[i, j] = currentValue++;
            }
        }
        int spaces = rows * colms;
        Console.WriteLine($"I have {rows} rows and {colms} columns. I need to fill-up {spaces} spaces.");
        Console.WriteLine($"The {rows}x{colms} array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colms; j++)
            {
                Console.Write(array[i, j] + "|");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"The {rows}x{colms} 2-D array flattened into a {spaces} cell 1-D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colms; j++)
            {
                Console.Write(array[i, j] + "|");
            }
        }
    }
}