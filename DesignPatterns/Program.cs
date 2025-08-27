using DesignPatterns.Behavioral;
using DesignPatterns.Creational;
using DesignPatterns.Structural;

namespace DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Design Patterns Demonstration");
        Console.WriteLine("===============================\n");

        RunCreationalPatterns();

        RunStructuralPatterns();

        RunBehavioralPatterns();

        Console.WriteLine("\n All patterns demonstrated successfully!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    private static void RunCreationalPatterns()
    {
        Console.WriteLine("CREATIONAL PATTERNS");
        Console.WriteLine("=======================");

        Console.WriteLine("\n1. Factory Pattern:");
        FactoryPatternDemo.Run();
        
        Console.WriteLine("\n2. Singleton Pattern:");
        SingletonPatternDemo.Run();
        
        Console.WriteLine("\n3. Builder Pattern:");
        BuilderPatternDemo.Run();
        
        Console.WriteLine("\n4. Abstract Factory Pattern:");
        AbstractFactoryPatternDemo.Run();
    }

    private static void RunStructuralPatterns()
    {
        Console.WriteLine("\n  STRUCTURAL PATTERNS");
        Console.WriteLine("=======================");
        
        Console.WriteLine("\n1. Adapter Pattern:");
        AdapterPatternDemo.Run();
        
        Console.WriteLine("\n2. Decorator Pattern:");
        DecoratorPatternDemo.Run();
        
        Console.WriteLine("\n3. Facade Pattern:");
        FacadePatternDemo.Run();
        
        Console.WriteLine("\n4. Composite Pattern:");
        CompositePatternDemo.Run();
    }

    private static void RunBehavioralPatterns()
    {
        Console.WriteLine("\n BEHAVIORAL PATTERNS");
        Console.WriteLine("=======================");
        
        Console.WriteLine("\n1. Observer Pattern:");
        ObserverPatternDemo.Run();
        
        Console.WriteLine("\n2. Strategy Pattern:");
        StrategyPatternDemo.Run();
        
        Console.WriteLine("\n3. Chain of Responsibility Pattern:");
        ChainOfResponsibilityPatternDemo.Run();
    }
}
