/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab6B
*/

using System;
class Lab6B
{
    static void Main(string[] args)
    {
        int userNum = 0;

        while (true)
        {
            Console.Write("Enter a number between 1 and 1000: ");
            if (int.TryParse(Console.ReadLine(), out userNum))
            {
                if (userNum >= 1 && userNum <= 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The number must be between 1 and 1000.");
                }
            }
            else
            {
                Console.WriteLine("Please enter an integer.");
            }
        }

        Random rnd = new Random();
        int guess;
        int guessCount = 0;

        do
        {
            guess = rnd.Next(1, 1001);
            guessCount++;
            Console.WriteLine($"My guess was {guess}");
        } while (guess != userNum);

        Console.WriteLine($"I guessed the number was {userNum} and it only took me {guessCount} guesses");
    }
}

