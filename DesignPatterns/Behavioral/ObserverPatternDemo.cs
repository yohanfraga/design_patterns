namespace DesignPatterns.Behavioral;

// Observer Pattern: Defines a one-to-many dependency between objects
public static class ObserverPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Demonstrating Observer Pattern...");
        
        var weatherStation = new WeatherStation();
        
        var phoneDisplay = new PhoneDisplay();
        var tvDisplay = new TVDisplay();
        var webDisplay = new WebDisplay();
        
        weatherStation.Subscribe(phoneDisplay);
        weatherStation.Subscribe(tvDisplay);
        weatherStation.Subscribe(webDisplay);
        
        Console.WriteLine("   Updating weather data...");
        weatherStation.SetMeasurements(25.5f, 65.0f, 1013.25f);
        
        weatherStation.Unsubscribe(tvDisplay);
        
        Console.WriteLine("   Updating weather data again...");
        weatherStation.SetMeasurements(28.0f, 70.0f, 1012.0f);
    }
}

public interface IObserver
{
    void Update(float temperature, float humidity, float pressure);
}

public interface ISubject
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void NotifyObservers();
}

public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers = new();
    private float _temperature;
    private float _humidity;
    private float _pressure;
    
    public void Subscribe(IObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
            Console.WriteLine($"   Observer subscribed: {observer.GetType().Name}");
        }
    }
    
    public void Unsubscribe(IObserver observer)
    {
        if (_observers.Remove(observer))
        {
            Console.WriteLine($"   Observer unsubscribed: {observer.GetType().Name}");
        }
    }
    
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature, _humidity, _pressure);
        }
    }
    
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        NotifyObservers();
    }
}

public class PhoneDisplay : IObserver
{
    public void Update(float temperature, float humidity, float pressure)
    {
        Console.WriteLine($"   📱 Phone Display: Temp={temperature}°C, Humidity={humidity}%, Pressure={pressure}hPa");
    }
}

public class TVDisplay : IObserver
{
    public void Update(float temperature, float humidity, float pressure)
    {
        Console.WriteLine($"   📺 TV Display: Temperature: {temperature}°C, Humidity: {humidity}%, Pressure: {pressure}hPa");
    }
}

public class WebDisplay : IObserver
{
    public void Update(float temperature, float humidity, float pressure)
    {
        Console.WriteLine($"   🌐 Web Display: T:{temperature}°C | H:{humidity}% | P:{pressure}hPa");
    }
}
