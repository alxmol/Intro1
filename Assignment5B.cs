/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment5B
*/
class Assignment5B
{
    static void Main(string[] args)
    {
        Console.WriteLine("[FYE Level Map Creator]");
        Console.Write("Enter a level map width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a level map height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        char[,] levelMap = new char[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                levelMap[i, j] = '-';
            }
        }

        int choice;
        while (true)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(levelMap[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Options");
            Console.WriteLine("1. Clear Level");
            Console.WriteLine("2. Add Platform");
            Console.WriteLine("3. Add Items");
            Console.WriteLine("4. Quit");
            Console.Write("Enter a choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("[Clear Level]");
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            levelMap[i, j] = '-';
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("[Add Platform]");
                    Console.Write("Enter X Coordinate: ");
                    int startX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Y Coordinate: ");
                    int startY = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Length: ");
                    int length = Convert.ToInt32(Console.ReadLine());

                    if (startX >= 0 && startX + length <= width && startY >= 0 && startY < height)
                    {
                        for (int i = startX; i < startX + length; i++)
                        {
                            levelMap[startY, i] = '=';
                        }
                    }
                    else
                    {
                        Console.WriteLine("This platform won't fit in the level!");
                    }
                    break;

                case 3:
                    Console.WriteLine("[Add Item]");
                    Console.Write("Enter X Coordinate: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Y Coordinate: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    if (x >= 0 && x < width && y >= 0 && y < height)
                    {
                        levelMap[y, x] = 'P';
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid location!");
                    }
                    break;

                case 4:
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write(levelMap[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Good bye!");
                    return;

                default:
                    Console.WriteLine("Please select a displayed option.");
                    break;
            }
        }
    }
}
