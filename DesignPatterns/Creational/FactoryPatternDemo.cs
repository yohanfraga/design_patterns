namespace DesignPatterns.Creational;

// Factory Pattern: Creates objects without specifying their exact classes
public static class FactoryPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Creating vehicles using Factory Pattern...");
        
        var car = VehicleFactory.CreateVehicle(EVehicleType.Car);
        var motorcycle = VehicleFactory.CreateVehicle(EVehicleType.Motorcycle);
        var truck = VehicleFactory.CreateVehicle(EVehicleType.Truck);
        
        Console.WriteLine($"   Created: {car.GetVehicleInfo()}");
        Console.WriteLine($"   Created: {motorcycle.GetVehicleInfo()}");
        Console.WriteLine($"   Created: {truck.GetVehicleInfo()}");
    }
}

public enum EVehicleType
{
    Car,
    Motorcycle,
    Truck
}

public abstract class Vehicle
{
    public abstract string GetVehicleInfo();
}

public class Car : Vehicle
{
    public override string GetVehicleInfo() => "Car - 4 wheels, enclosed cabin";
}

public class Motorcycle : Vehicle
{
    public override string GetVehicleInfo() => "Motorcycle - 2 wheels, open design";
}

public class Truck : Vehicle
{
    public override string GetVehicleInfo() => "Truck - 6+ wheels, cargo area";
}

public static class VehicleFactory
{
    public static Vehicle CreateVehicle(EVehicleType type) =>
        type switch
        {
            EVehicleType.Car => new Car(),
            EVehicleType.Motorcycle => new Motorcycle(),
            EVehicleType.Truck => new Truck(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
}
