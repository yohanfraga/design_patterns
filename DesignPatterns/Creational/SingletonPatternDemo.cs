namespace DesignPatterns.Creational;

// Singleton Pattern: Ensures a class has only one instance and provides global access
public static class SingletonPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Demonstrating Singleton Pattern...");
        
        // Get the singleton instance
        var config1 = ConfigurationManager.Instance;
        var config2 = ConfigurationManager.Instance;
        
        Console.WriteLine($"   Config1 ID: {config1.GetHashCode()}");
        Console.WriteLine($"   Config2 ID: {config2.GetHashCode()}");
        Console.WriteLine($"   Same instance? {ReferenceEquals(config1, config2)}");
        
        // Use the singleton
        config1.SetSetting("Database", "localhost");
        config1.SetSetting("Port", "5432");
        
        Console.WriteLine($"   Database: {config2.GetSetting("Database")}");
        Console.WriteLine($"   Port: {config2.GetSetting("Port")}");
    }
}

public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance = 
        new Lazy<ConfigurationManager>(() => new ConfigurationManager());
    
    private readonly Dictionary<string, string> _settings = new();
    
    private ConfigurationManager() { }
    
    public static ConfigurationManager Instance => _instance.Value;
    
    public void SetSetting(string key, string value)
    {
        _settings[key] = value;
    }
    
    public string GetSetting(string key)
    {
        return _settings.TryGetValue(key, out var value) ? value : "Not found";
    }
}
