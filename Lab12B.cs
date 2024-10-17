using System;
/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: La12B
*/
public class Dog
{
    public int Age { get; set; }
    public double Weight { get; set; }
    public string Name { get; set; }
    public string FurColor { get; set; }
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }

    public void Rename(string newName)
    {
        Name = newName;
    }

    public void Eat(double amount)
    {
        Weight += amount;
    }

    public override string ToString()
    {
        return $"\n{Name} is a {Age} year old {FurColor} {Breed} that weighs {Weight} lbs.\n";
    }
}

public class Lab12B
{
    public static void Main(string[] args)
    {
        Dog myDog = new Dog();

        Console.WriteLine("You are about to create a dog");

        Console.Write("How old is the dog: ");
        myDog.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("How much does the dog weigh: ");
        myDog.Weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("What is the dog's name: ");
        myDog.Name = Console.ReadLine();

        Console.Write("What color is the dog: ");
        myDog.FurColor = Console.ReadLine();

        Console.Write("What breed is the dog: ");
        myDog.Breed = Console.ReadLine();

        Console.WriteLine(myDog.ToString());

        myDog.Bark();

        Console.Write($"{myDog.Name} is hungry, how much should he eat: ");
        myDog.Eat(Convert.ToDouble(Console.ReadLine()));

        Console.Write($"{myDog.Name} isn't a very good name. What should they be renamed to: ");
        myDog.Rename(Console.ReadLine());

        Console.WriteLine(myDog.ToString());
    }
}

