namespace DesignPatterns.Creational;

// Builder Pattern: Constructs complex objects step by step
public static class BuilderPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Building computers using Builder Pattern...");
        
        var gamingComputer = new ComputerBuilder()
            .SetProcessor("Intel i9-13900K")
            .SetMemory("32GB DDR5")
            .SetStorage("2TB NVMe SSD")
            .SetGraphicsCard("RTX 4090")
            .Build();
            
        var officeComputer = new ComputerBuilder()
            .SetProcessor("Intel i5-13400")
            .SetMemory("16GB DDR4")
            .SetStorage("512GB SSD")
            .Build();
            
        Console.WriteLine($"   Gaming PC: {gamingComputer}");
        Console.WriteLine($"   Office PC: {officeComputer}");
    }
}

public class Computer
{
    public string Processor { get; set; } = "Default";
    public string Memory { get; set; } = "Default";
    public string Storage { get; set; } = "Default";
    public string GraphicsCard { get; set; } = "Integrated";
    
    public override string ToString()
    {
        return $"CPU: {Processor}, RAM: {Memory}, Storage: {Storage}, GPU: {GraphicsCard}";
    }
}

public class ComputerBuilder
{
    private readonly Computer _computer = new();
    
    public Computer Build() => _computer;
    
    public ComputerBuilder SetProcessor(string processor)
    {
        _computer.Processor = processor;
        return this;
    }
    
    public ComputerBuilder SetMemory(string memory)
    {
        _computer.Memory = memory;
        return this;
    }
    
    public ComputerBuilder SetStorage(string storage)
    {
        _computer.Storage = storage;
        return this;
    }
    
    public ComputerBuilder SetGraphicsCard(string graphicsCard)
    {
        _computer.GraphicsCard = graphicsCard;
        return this;
    }
}
