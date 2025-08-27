namespace DesignPatterns.Structural;

// Facade Pattern: Provides a simplified interface to a complex subsystem
public static class FacadePatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Demonstrating Facade Pattern...");
        
        var homeAutomation = new HomeAutomationFacade();
        
        Console.WriteLine("   Good morning routine:");
        homeAutomation.GoodMorning();
        
        Console.WriteLine("   Good night routine:");
        homeAutomation.GoodNight();
        
        Console.WriteLine("   Movie mode:");
        homeAutomation.MovieMode();
    }
}

public class Lights
{
    public void TurnOn() => Console.WriteLine("   Lights turned on");
    public void TurnOff() => Console.WriteLine("   Lights turned off");
    public void Dim(int percentage) => Console.WriteLine($"   Lights dimmed to {percentage}%");
}

public class AudioSystem
{
    public void TurnOn() => Console.WriteLine("   Audio system turned on");
    public void TurnOff() => Console.WriteLine("   Audio system turned off");
    public void SetVolume(int level) => Console.WriteLine($"   Volume set to {level}");
    public void PlayMovie() => Console.WriteLine("   Movie audio playing");
}

public class Thermostat
{
    public void SetTemperature(int temperature) => Console.WriteLine($"   Temperature set to {temperature}°C");
    public void TurnOff() => Console.WriteLine("   Thermostat turned off");
}

public class SecuritySystem
{
    public void Arm() => Console.WriteLine("   Security system armed");
    public void Disarm() => Console.WriteLine("   Security system disarmed");
}

public class HomeAutomationFacade
{
    private readonly Lights _lights = new();
    private readonly AudioSystem _audio = new();
    private readonly Thermostat _thermostat = new();
    private readonly SecuritySystem _security = new();
    
    public void GoodMorning()
    {
        _lights.TurnOn();
        _thermostat.SetTemperature(22);
        _security.Disarm();
        Console.WriteLine("   Good morning routine completed!");
    }
    
    public void GoodNight()
    {
        _lights.TurnOff();
        _audio.TurnOff();
        _thermostat.SetTemperature(18);
        _security.Arm();
        Console.WriteLine("   Good night routine completed!");
    }
    
    public void MovieMode()
    {
        _lights.Dim(20);
        _audio.TurnOn();
        _audio.SetVolume(70);
        _audio.PlayMovie();
        Console.WriteLine("   Movie mode activated!");
    }
}
