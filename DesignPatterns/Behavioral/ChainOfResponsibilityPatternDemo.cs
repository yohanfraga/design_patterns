namespace DesignPatterns.Behavioral;

// Chain of Responsibility Pattern: Passes requests along a chain of handlers
public static class ChainOfResponsibilityPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Demonstrating Chain of Responsibility Pattern...");
        
        var lowLevelSupport = new LowLevelSupport();
        var mediumLevelSupport = new MediumLevelSupport();
        var highLevelSupport = new HighLevelSupport();
        var manager = new Manager();
        
        lowLevelSupport.SetNext(mediumLevelSupport);
        mediumLevelSupport.SetNext(highLevelSupport);
        highLevelSupport.SetNext(manager);
        
        var tickets = new[]
        {
            new SupportTicket("Password reset", ETicketPriority.Low),
            new SupportTicket("Software installation", ETicketPriority.Medium),
            new SupportTicket("Server down", ETicketPriority.High),
            new SupportTicket("Database corruption", ETicketPriority.Critical)
        };
        
        foreach (var ticket in tickets)
        {
            Console.WriteLine($"   Processing ticket: {ticket.Description} (Priority: {ticket.Priority})");
            lowLevelSupport.HandleTicket(ticket);
            Console.WriteLine();
        }
    }
}

public enum ETicketPriority
{
    Low,
    Medium,
    High,
    Critical
}

public class SupportTicket
{
    public string Description { get; }
    public ETicketPriority Priority { get; }
    
    public SupportTicket(string description, ETicketPriority priority)
    {
        Description = description;
        Priority = priority;
    }
}

public abstract class SupportHandler
{
    protected SupportHandler? NextHandler { get; private set; }
    
    public void SetNext(SupportHandler handler)
    {
        NextHandler = handler;
    }
    
    public abstract void HandleTicket(SupportTicket ticket);
    
    protected void PassToNext(SupportTicket ticket)
    {
        NextHandler?.HandleTicket(ticket);
    }
}

public class LowLevelSupport : SupportHandler
{
    public override void HandleTicket(SupportTicket ticket)
    {
        if (ticket.Priority == ETicketPriority.Low)
        {
            Console.WriteLine("   ✅ Low Level Support: Ticket resolved (password reset, basic questions)");
        }
        else
        {
            Console.WriteLine("   🔄 Low Level Support: Escalating to next level");
            PassToNext(ticket);
        }
    }
}

public class MediumLevelSupport : SupportHandler
{
    public override void HandleTicket(SupportTicket ticket)
    {
        if (ticket.Priority == ETicketPriority.Medium)
        {
            Console.WriteLine("   ✅ Medium Level Support: Ticket resolved (software installation, configuration)");
        }
        else
        {
            Console.WriteLine("   🔄 Medium Level Support: Escalating to next level");
            PassToNext(ticket);
        }
    }
}

public class HighLevelSupport : SupportHandler
{
    public override void HandleTicket(SupportTicket ticket)
    {
        if (ticket.Priority == ETicketPriority.High)
        {
            Console.WriteLine("   ✅ High Level Support: Ticket resolved (server issues, complex problems)");
        }
        else
        {
            Console.WriteLine("   🔄 High Level Support: Escalating to manager");
            PassToNext(ticket);
        }
    }
}

public class Manager : SupportHandler
{
    public override void HandleTicket(SupportTicket ticket)
    {
        if (ticket.Priority == ETicketPriority.Critical)
        {
            Console.WriteLine("   ✅ Manager: Critical ticket handled (database corruption, system failure)");
            Console.WriteLine("   🚨 Initiating emergency procedures and team mobilization");
        }
        else
        {
            Console.WriteLine("   ❌ Manager: Unable to handle ticket");
        }
    }
}
