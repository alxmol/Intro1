using System;

public class BuildingBlueprint
{
    private int stories;
    private int apartments;
    private float occupancyRate;
    private bool fullyOccupied;

    public BuildingBlueprint()
    {
        stories = 10;
        apartments = 20;
        occupancyRate = 1.0f;
        fullyOccupied = true;
    }

    public BuildingBlueprint(int stories, int apartments, float occupancyRate)
    {
        this.stories = stories;
        this.apartments = apartments;
        this.occupancyRate = occupancyRate;
        this.fullyOccupied = occupancyRate == 1.0f;
    }

    public int Stories
    {
        get { return stories; }
        set { stories = value; }
    }

    public int Apartments
    {
        get { return apartments; }
        set { apartments = value; }
    }
    public float OccupancyRate
    {
        get { return occupancyRate; }
        set
        {
            occupancyRate = value;
            fullyOccupied = occupancyRate == 1.0f;
        }
    }
    public bool FullyOccupied
    {
        get { return fullyOccupied; }
    }

    public override string ToString()
    {
        return $"has {stories} floors, {apartments} apartments, and is {occupancyRate * 100}%% occupied. Full? {(fullyOccupied ? "true" : "false")}";
    }
}

public class Lab13A
{
    static void Main()
    {
        BuildingBlueprint buildingOne = new BuildingBlueprint();
        BuildingBlueprint buildingTwo = new BuildingBlueprint(30, 30, 0.75f);
        Console.WriteLine("Year 2020:");
        Console.WriteLine($"Building 1 {buildingOne}");
        Console.WriteLine($"Building 1 {buildingTwo}");
        buildingOne.OccupancyRate = 0.0f;
        buildingTwo.OccupancyRate = 1.0f;

        Console.WriteLine("\nMany years pass.\n");
        Console.WriteLine("Year 2043:");
        Console.WriteLine($"Building 1 {buildingOne}");
        Console.WriteLine($"Building 1 {buildingTwo}");
    }
}
