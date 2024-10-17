/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment5A
*/
class Assignment5A
{
    static void Main(string[] args)
    {
        Random choice = new Random();
        string[] choices = { "Rock", "Paper", "Scissors" };
        string[] results;

        Console.Write("How many games do you want to play?: ");
        int loop = Convert.ToInt32(Console.ReadLine());
        results = new string[loop];

        for (int i = 0; i < loop; i++)
        {
            Console.Write($"Round {i + 1}: What do you want to throw?: ");
            string playerChoice = Console.ReadLine();
            string computerChoice = choices[choice.Next(3)];
            Console.WriteLine($"Computer threw {computerChoice}!");

            if (playerChoice.ToUpper() == computerChoice.ToUpper())
            {
                results[i] = $"Tied on Round {i + 1} with {playerChoice}";
            }
            else if ((playerChoice.ToUpper() == "ROCK" && computerChoice.ToUpper() == "SCISSORS") ||
                     (playerChoice.ToUpper() == "PAPER" && computerChoice.ToUpper() == "ROCK") ||
                     (playerChoice.ToUpper() == "SCISSORS" && computerChoice.ToUpper() == "PAPER"))
            {
                results[i] = $"Player won Round {i + 1} with {playerChoice}";
            }
            else
            {
                results[i] = $"Computer won Round {i + 1} with {computerChoice}";
            }
        }

        Console.WriteLine("Game Over...\n");
        Console.WriteLine("Here's the recap:");

        foreach (string result in results)
        {
            Console.WriteLine(result);
        }
    }
}

