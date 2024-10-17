/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment2B
*/

class Assignment2C
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Bisonica!");
        Console.Write("How many US Dollars do you have? ");
        int dollars = Convert.ToInt32(Console.ReadLine());
        double pounds = dollars * .79;
        double bison = pounds / 5;
        Console.WriteLine($"{dollars} US Dollar(s) is {pounds} British Pound(s),\nwhich is {bison} Bison Dollar(s)!");
    }
}