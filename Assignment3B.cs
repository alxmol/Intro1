/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment3B
*/

using System;
class Assignment3B
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Image Encoding Checker]");
        Console.Write("What is the image width? ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("What is the image height? ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("What is the file size (in bytes)? ");
        int fileSize = int.Parse(Console.ReadLine());

        if (width <= 0 || height <= 0 || fileSize <= 0)
        {
            Console.WriteLine("The information is invalid – please re-enter it.");
            return;
        }

        int pixels = width * height;
        int bits = (fileSize * 8) / pixels;

        int bpc = bits / 4;

        switch (bpc)
        {
            case 8:
                Console.WriteLine("The RGBA image is encoded with 8 bits per channel.");
                break;
            case 16:
                Console.WriteLine("The RGBA image is encoded with 16 bits per channel.");
                break;
            case 32:
                Console.WriteLine("The RGBA image is encoded with 32 bits per channel.");
                break;
            default:
                Console.WriteLine("The information is invalid – please re-enter it.");
                break;
        }
    }
}