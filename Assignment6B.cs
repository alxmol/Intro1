/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment6B
*/

using System;

class Assignment6B
{
    static void Main()
    {
        const int size = 8;

        Console.WriteLine("[Overloaded Sort]");
        Console.Write("What data type do you want to enter? ");
        string type = Console.ReadLine();

        switch (type.ToLower())
        {
            case "int":
                int[] intArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    intArray[i] = int.Parse(Console.ReadLine());
                }
                arraySort(intArray);
                break;

            case "char":
                char[] charArray = new char[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    charArray[i] = Console.ReadLine()[0];
                }
                arraySort(charArray);
                break;

            case "float":
                float[] floatArray = new float[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    floatArray[i] = float.Parse(Console.ReadLine());
                }
                arraySort(floatArray);
                break;

            default:
                Console.WriteLine("Unspecified data type entered.");
                break;
        }
    }

    static void arraySort(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine("Calling arraySort()...");
        Console.WriteLine("The sorted values are:");
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }

    static void arraySort(char[] array)
    {
        Array.Sort(array);
        Console.WriteLine("Calling arraySort()...");
        Console.WriteLine("The sorted values are:");
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }

    static void arraySort(float[] array)
    {
        Array.Sort(array);
        Console.WriteLine("Calling arraySort()...");
        Console.WriteLine("The sorted values are:");
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }
}
