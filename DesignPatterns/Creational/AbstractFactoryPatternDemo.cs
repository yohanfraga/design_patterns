namespace DesignPatterns.Creational;

// Abstract Factory Pattern: Creates families of related objects
public static class AbstractFactoryPatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Creating UI components using Abstract Factory Pattern...");
        
        // Create Windows UI components
        var windowsFactory = new WindowsUIFactory();
        var windowsButton = windowsFactory.CreateButton();
        var windowsTextBox = windowsFactory.CreateTextBox();
        
        // Create Mac UI components
        var macFactory = new MacUIFactory();
        var macButton = macFactory.CreateButton();
        var macTextBox = macFactory.CreateTextBox();
        
        Console.WriteLine($"   Windows Button: {windowsButton.Render()}");
        Console.WriteLine($"   Windows TextBox: {windowsTextBox.Render()}");
        Console.WriteLine($"   Mac Button: {macButton.Render()}");
        Console.WriteLine($"   Mac TextBox: {macTextBox.Render()}");
    }
}

public interface IButton
{
    string Render();
}

public interface ITextBox
{
    string Render();
}

public interface IUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}

public class WindowsButton : IButton
{
    public string Render() => "Windows-style button with blue theme";
}

public class WindowsTextBox : ITextBox
{
    public string Render() => "Windows-style textbox with gray border";
}

public class MacButton : IButton
{
    public string Render() => "Mac-style button with rounded corners";
}

public class MacTextBox : ITextBox
{
    public string Render() => "Mac-style textbox with subtle shadow";
}

public class WindowsUIFactory : IUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ITextBox CreateTextBox() => new WindowsTextBox();
}

public class MacUIFactory : IUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ITextBox CreateTextBox() => new MacTextBox();
}
