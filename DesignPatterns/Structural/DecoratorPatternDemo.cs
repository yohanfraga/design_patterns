namespace DesignPatterns.Structural;

// Decorator Pattern: Adds behavior to objects dynamically
public static class DecoratorPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Demonstrating Decorator Pattern...");
        
        // Base coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"   Cost: ${coffee.Cost:F2}, Description: {coffee.Description}");
        
        // Add milk
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"   Cost: ${coffee.Cost:F2}, Description: {coffee.Description}");
        
        // Add sugar
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"   Cost: ${coffee.Cost:F2}, Description: {coffee.Description}");
        
        // Add whipped cream
        coffee = new WhippedCreamDecorator(coffee);
        Console.WriteLine($"   Cost: ${coffee.Cost:F2}, Description: {coffee.Description}");
    }
}

public interface ICoffee
{
    decimal Cost { get; }
    string Description { get; }
}

public class SimpleCoffee : ICoffee
{
    public decimal Cost => 2.00m;
    public string Description => "Simple coffee";
}

public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;
    
    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    
    public virtual decimal Cost => _coffee.Cost;
    public virtual string Description => _coffee.Description;
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }
    
    public override decimal Cost => _coffee.Cost + 0.50m;
    public override string Description => _coffee.Description + ", milk";
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }
    
    public override decimal Cost => _coffee.Cost + 0.25m;
    public override string Description => _coffee.Description + ", sugar";
}

public class WhippedCreamDecorator : CoffeeDecorator
{
    public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }
    
    public override decimal Cost => _coffee.Cost + 0.75m;
    public override string Description => _coffee.Description + ", whipped cream";
}
