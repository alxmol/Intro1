/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment7B
*/
using System;

class Pixel
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public Pixel()
    {
        Red = 255;
        Green = 255;
        Blue = 255;
    }

    public Pixel(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public void changeRGB(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public void printRGB()
    {
        Console.WriteLine($"{Red} {Green} {Blue}");
    }
}

class Assignment7B
{
    static Pixel[,] InitializePixels(int width, int height, Pixel initialPixel)
    {
        Pixel[,] pixels = new Pixel[width, height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                pixels[i, j] = new Pixel(initialPixel.Red, initialPixel.Green, initialPixel.Blue);
            }
        }
        return pixels;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("[Portable Pix Map Art Program]");
        Console.Write("Enter an image width: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter an image height: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Enter the fill color's red value: ");
        int initialRed = int.Parse(Console.ReadLine());
        Console.Write("Enter the fill color's green value: ");
        int initialGreen = int.Parse(Console.ReadLine());
        Console.Write("Enter the fill color's blue value: ");
        int initialBlue = int.Parse(Console.ReadLine());

        Pixel initialPixel = new Pixel(initialRed, initialGreen, initialBlue);
        Pixel[,] pixels = InitializePixels(width, height, initialPixel);

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("What will you do?");
            Console.WriteLine("1) Fill in a pixel");
            Console.WriteLine("2) Fill in a line");
            Console.WriteLine("3) Print the image");
            Console.WriteLine("4) Quit");
            Console.Write("Choice? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    ChangePixelColor(pixels);
                    break;
                case "2":
                    Console.WriteLine();
                    ChangeLineOfPixelsColor(pixels);
                    break;
                case "3":
                    Console.WriteLine();
                    PrintPPMFile(pixels, width, height);
                    break;
                case "4":
                    Console.WriteLine();
                    PrintPPMFile(pixels, width, height);
                    Console.WriteLine("Closing...");
                    running = false;
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Select a valid option.");
                    break;
            }
        }
    }

    static void ChangePixelColor(Pixel[,] pixels)
    {
        Console.Write("Row: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Column: ");
        int column = int.Parse(Console.ReadLine());

        Console.Write("New Red Color: ");
        int newR = int.Parse(Console.ReadLine());

        Console.Write("New Green Color: ");
        int newG = int.Parse(Console.ReadLine());

        Console.Write("New Blue Color: ");
        int newB = int.Parse(Console.ReadLine());

        if (row < 0 || row >= pixels.GetLength(0) || column < 0 || column >= pixels.GetLength(1))
        {
            Console.WriteLine("Coordinates are out of bounds.");
            return;
        }

        pixels[column, row].changeRGB(newR, newG, newB);
    }

    static void ChangeLineOfPixelsColor(Pixel[,] pixels)
    {
        Console.Write("Row: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Column: ");
        int column = int.Parse(Console.ReadLine());

        Console.Write("Length: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("New Red Color: ");
        int newR = int.Parse(Console.ReadLine());

        Console.Write("New Green Color: ");
        int newG = int.Parse(Console.ReadLine());

        Console.Write("New Blue Color: ");
        int newB = int.Parse(Console.ReadLine());

        if (row < 0 || row >= pixels.GetLength(1) || column < 0 || column + length > pixels.GetLength(0))
        {
            Console.WriteLine("Coordinates/length out of bounds.");
            return;
        }

        for (int i = column; i < column + length && i < pixels.GetLength(0); i++)
        {
            pixels[i, row].changeRGB(newR, newG, newB);
        }
    }

    static void PrintPPMFile(Pixel[,] pixels, int width, int height)
    {
        Console.WriteLine("P3");
        Console.WriteLine($"{width} {height}");
        Console.WriteLine("255");
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write($"{pixels[j, i].Red} {pixels[j, i].Green} {pixels[j, i].Blue} ");
            }
            Console.WriteLine();
        }
    }
}
