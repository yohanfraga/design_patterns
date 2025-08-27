namespace DesignPatterns.Behavioral;

// Strategy Pattern: Defines a family of algorithms and makes them interchangeable
public static class StrategyPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Demonstrating Strategy Pattern...");
        
        var shoppingCart = new ShoppingCart();

        shoppingCart.SetPaymentStrategy(new CreditCardPayment());
        shoppingCart.ProcessPayment(100.0m);
        
        shoppingCart.SetPaymentStrategy(new PayPalPayment());
        shoppingCart.ProcessPayment(50.0m);
        
        shoppingCart.SetPaymentStrategy(new CryptoPayment());
        shoppingCart.ProcessPayment(75.0m);
        
        shoppingCart.SetPaymentStrategy(new BankTransferPayment());
        shoppingCart.ProcessPayment(200.0m);
    }
}

public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}

public class CreditCardPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"   💳 Processing ${amount} via Credit Card");
        Console.WriteLine("   Validating card details...");
        Console.WriteLine("   Payment processed successfully!");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"   📧 Processing ${amount} via PayPal");
        Console.WriteLine("   Redirecting to PayPal...");
        Console.WriteLine("   Payment completed!");
    }
}

public class CryptoPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"   ₿ Processing ${amount} via Cryptocurrency");
        Console.WriteLine("   Generating wallet address...");
        Console.WriteLine("   Waiting for blockchain confirmation...");
        Console.WriteLine("   Payment confirmed on blockchain!");
    }
}

public class BankTransferPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"   🏦 Processing ${amount} via Bank Transfer");
        Console.WriteLine("   Initiating bank transfer...");
        Console.WriteLine("   Transfer will complete in 1-3 business days");
    }
}

public class ShoppingCart
{
    private IPaymentStrategy _paymentStrategy = new CreditCardPayment();
    
    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        _paymentStrategy = strategy;
    }
    
    public void ProcessPayment(decimal amount)
    {
        _paymentStrategy.ProcessPayment(amount);
        Console.WriteLine();
    }
}
