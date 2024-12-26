using System;

public class Vehicle
{
    public string Name { get; set; }
    private int speed;
    public static int TotalVehicles;

    public Vehicle(string name, int startingSpeed)
    {
        Name = name;
        speed = startingSpeed;
        TotalVehicles++;
    }

    public virtual void Start() => Console.WriteLine("Vehicle is starting!");
    public void Accelerate(int increment) => speed += increment;
    public int GetSpeed() => speed;
}

public class Car : Vehicle
{
    public Car(string name, int startingSpeed) : base(name, startingSpeed) { }
    public override void Start() => Console.WriteLine("The car is starting with a smooth engine sound!");
}

public class Motorcycle : Vehicle
{
    public Motorcycle(string name, int startingSpeed) : base(name, startingSpeed) { }
    public override void Start() => Console.WriteLine("The motorcycle roars to life!");
   
}

public class Truck : Vehicle
{
    public Truck(string name, int startingSpeed) : base(name, startingSpeed) { }
    public override void Start() => Console.WriteLine("The truck's heavy engine rumbles as it starts!");
}

class Program
{
    static void Main()
    {
        Vehicle[] vehicles = {
            new Car("Car", 10),
            new Motorcycle("Motorcycle", 20),
            new Truck("Truck", 15)
        };

        foreach (var vehicle in vehicles)
            vehicle.Start();

        vehicles[0].Accelerate(10); // Car
        vehicles[1].Accelerate(20); // Motorcycle
        vehicles[2].Accelerate(15); // Truck

        foreach (var vehicle in vehicles)
            Console.WriteLine($"{vehicle.Name} speed: {vehicle.GetSpeed()} mph");

        Console.WriteLine($"Total vehicles created: {Vehicle.TotalVehicles}");
    }
}

