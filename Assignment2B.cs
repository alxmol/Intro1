/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment2C
*/
class Assignment2B
{
    static void Main(string[] args)
    {
        Console.Write("Enter the hit box bottom-left X coordinate: ");
        int bl_x = int.Parse(Console.ReadLine());
        Console.Write("Enter the hit box bottom-left Y coordinate: ");
        int bl_y = int.Parse(Console.ReadLine());
        Console.Write("Enter the width of the hit box: ");
        int hb_w = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of the hit box: ");
        int hb_h = int.Parse(Console.ReadLine());

        int br_x = bl_x + hb_w;
        int br_y = bl_y;
        int tl_x = bl_x;
        int tl_y = bl_y + hb_h;
        int tr_x = br_x;
        int tr_y = br_y + hb_h;

        Console.WriteLine("[Hit Box Coordinates]");
        Console.WriteLine($"Bottom-Left: {bl_x}, {bl_y}");
        Console.WriteLine($"Top-Left: {tl_x}, {tl_y}");
        Console.WriteLine($"Bottom-Right: {br_x}, {br_y}");
        Console.WriteLine($"Top-Right: {tr_x}, {tr_y}");
    }
}
