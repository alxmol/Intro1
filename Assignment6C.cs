/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment6C
*/

class Assignment6C
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Minesweeper – DOS Edition]");
        Console.Write("What is the grid size? ");
        int size = int.Parse(Console.ReadLine());

        char[,] grid = new char[size, size];
        int[] mineLocations = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            mineLocations[i] = random.Next(size);
            for (int j = 0; j < size; j++)
            {
                grid[j, i] = '?';
            }
        }

        bool gameOver = false;
        int turns = 0;

        while (!gameOver && turns < size * size)
        {
            PrintGrid(grid);

            Console.Write("Enter your X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter your Y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (mineLocations[x] == y)
            {
                grid[y, x] = 'X';
                PrintGrid(grid);
                Console.WriteLine("Sorry, you hit a mine!");
                gameOver = true;
            }
            else
            {
                grid[y, x] = '_';
                turns++;

                if (turns == size * size - size)
                {
                    grid[y, x] = '_';
                    PrintGrid(grid);
                    Console.WriteLine("You win!");
                    gameOver = true;
                }
            }
        }
    }

    static void PrintGrid(char[,] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Console.Write(grid[i, j]);
            }
            Console.WriteLine();
        }
    }
}