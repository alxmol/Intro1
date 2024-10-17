using System;
/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment7A
*/
using System;

public class Assignment7A
{
    public static void Main()
    {
        Console.WriteLine("[Finite State Automata]");
        Console.Write("What state do you want to start at? ");
        int startState = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        FSA fsa = new FSA(startState);

        while (true)
        {
            Console.WriteLine("What will you do?");
            Console.WriteLine(">Go to next state");
            Console.WriteLine(">End");
            string command = Console.ReadLine();

            if (command.Equals("Go to next state", StringComparison.OrdinalIgnoreCase))
            {
                int currentState = fsa.goToNextState();
                Console.WriteLine();
                Console.WriteLine($"You're now at state {currentState}.");
            }
            else if (command.Equals("End", StringComparison.OrdinalIgnoreCase))
            {
                if (fsa.end())
                {
                    Console.WriteLine();
                    Console.WriteLine("The FSA has shut down.");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You can't stop here; you can only stop at state 3.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("[Invalid command!]");
                Console.WriteLine();
            }
        }
    }
}
