/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment3A
*/
using System;
class Assignment3A
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Scrappy’s Bucket List Rewards]");
        Console.Write("How many events have you attended? ");
        int events = Convert.ToInt32(Console.ReadLine());
        double percent = (double)events / 63;
        double percentWhole = Math.Truncate(percent * 100);

        if (percent >= 1.00)
        {
            Console.WriteLine($"You’ve been to {percentWhole}% of all SBL events!");
            Console.WriteLine("You’ve earned a Drawstring Bag!");
            Console.WriteLine("You’ve earned a Hat!");
            Console.WriteLine("You’ve earned a T-Shirt!");
            Console.WriteLine("You’ve earned a Glass Water Bottle!");
            Console.WriteLine("You’ve earned a Hoodie!");

        }
        else if (percent >= 0.75)
        {
            Console.WriteLine($"You’ve been to {percentWhole}% of all SBL events!");
            Console.WriteLine("You’ve earned a Drawstring Bag!");
            Console.WriteLine("You’ve earned a Hat!");
            Console.WriteLine("You’ve earned a T-Shirt!");
            Console.WriteLine("You’ve earned a Glass Water Bottle!");
        }
        else if (percent >= 0.50)
        {
            Console.WriteLine($"You’ve been to {percentWhole}% of all SBL events!");
            Console.WriteLine("You’ve earned a Drawstring Bag!");
            Console.WriteLine("You’ve earned a Hat!");
            Console.WriteLine("You’ve earned a T-Shirt!");
        }
        else if (percent >= 0.25)
        {
            Console.WriteLine($"You’ve been to {percentWhole}% of all SBL events!");
            Console.WriteLine("You’ve earned a Drawstring Bag!");
            Console.WriteLine("You’ve earned a Hat!");
        }
        else if (percent >= 0.10)
        {
            Console.WriteLine($"You’ve been to {percentWhole}% of all SBL events!");
            Console.WriteLine("You’ve earned a Drawstring Bag!");
        }
        else
        {
            Console.WriteLine("Check out events at https://studentaffairs.kennesaw.edu/scrappysbucketlist/!");
        }

        if (percent == 1.00)
        {
            Console.Write("Are you graduating? ");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Console.WriteLine("Hooray, you earned a Challenge Coin and special graduation cords!");
            }
            else
                Console.WriteLine("There’s a special reward when you graduate!");
        }

    }
}

