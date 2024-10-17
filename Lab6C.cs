/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Lab6C
*/

using System;
class Lab6C
{
    static void Main(string[] args)
    {
        int balance = 1000;

        Console.WriteLine($"Welcome!\nYou have ${balance} in your account.\n");

        while (true)
        {
            Console.WriteLine("\nMenu\n0) Make a deposit\n1) Make a withdrawal\n2) Display account value\n");
            Console.Write("Please make a selection: ");
            short selection = short.Parse(Console.ReadLine());

            switch (selection)
            {
                case 0:
                    Console.Write("How much would you like to deposit? : ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine($"Your current balance is ${balance}");
                    Console.Write("Would you like to return to the main menu (Y/N)? : ");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        Console.WriteLine("\nThank you for banking with us!");
                        return;
                    }
                        break;

                case 1:
                    Console.Write("How much would you like to withdraw? : ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    balance -= withdraw;
                    Console.WriteLine($"Your current balance is ${balance}");
                    Console.Write("Would you like to return to the main menu (Y/N)? : ");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        Console.WriteLine("\nThank you for banking with us!");
                        return;
                    }
                        break;

                case 2:
                    Console.WriteLine($"Your current balance is ${balance}");
                    Console.Write("Would you like to return to the main menu (Y/N)? : ");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        Console.WriteLine("\nThank you for banking with us!");
                        return;
                    }
                        break;

                default:
                    Console.WriteLine("Invalid entry, please try again.");
                    Console.Write("Would you like to return to the main menu (Y/N)? : ");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        Console.WriteLine("\nThank you for banking with us!");
                        return;
                    }
                        break;
            }
        }
    }
}

