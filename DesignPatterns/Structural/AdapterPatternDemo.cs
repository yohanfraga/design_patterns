namespace DesignPatterns.Structural;

// Adapter Pattern: Allows incompatible interfaces to work together
public static class AdapterPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Demonstrating Adapter Pattern...");
        
        // Modern payment system expects IPaymentProcessor
        var paymentSystem = new PaymentSystem();
        
        // Legacy payment system that doesn't implement IPaymentProcessor
        var legacyPayment = new LegacyPaymentSystem();
        
        // Adapter makes legacy system compatible
        var adapter = new LegacyPaymentAdapter(legacyPayment);
        
        // Both work with the same interface
        paymentSystem.ProcessPayment(100.0m);
        paymentSystem.ProcessPayment(adapter);
    }
}

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class PaymentSystem
{
    public void ProcessPayment(IPaymentProcessor processor)
    {
        processor.ProcessPayment(50.0m);
    }
    
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"   Processing payment of ${amount} via modern system");
    }
}

// Legacy system with different interface
public class LegacyPaymentSystem
{
    public void ChargeAmount(decimal amount)
    {
        Console.WriteLine($"   Legacy system charging ${amount}");
    }
}

// Adapter makes legacy system compatible
public class LegacyPaymentAdapter : IPaymentProcessor
{
    private readonly LegacyPaymentSystem _legacySystem;
    
    public LegacyPaymentAdapter(LegacyPaymentSystem legacySystem)
    {
        _legacySystem = legacySystem;
    }
    
    public void ProcessPayment(decimal amount)
    {
        _legacySystem.ChargeAmount(amount);
    }
}
