namespace DesignPatterns.Structural;

// Composite Pattern: Treats individual objects and compositions uniformly
public static class CompositePatternDemo
{
    public static void Run()
    {
        Console.WriteLine("   Demonstrating Composite Pattern...");
        
        var root = new Directory("Root");
        var documents = new Directory("Documents");
        var pictures = new Directory("Pictures");
        
        var file1 = new File("report.txt", 1024);
        var file2 = new File("image.jpg", 2048);
        var file3 = new File("document.pdf", 5120);
        
        documents.Add(file1);
        documents.Add(file3);
        pictures.Add(file2);
        
        root.Add(documents);
        root.Add(pictures);
        
        Console.WriteLine($"   Root size: {root.GetSize()} bytes");
        Console.WriteLine($"   Documents size: {documents.GetSize()} bytes");
        Console.WriteLine($"   Pictures size: {pictures.GetSize()} bytes");
        
        Console.WriteLine("   File structure:");
        root.Display(0);
    }
}

public abstract class FileSystemItem
{
    protected string Name { get; }
    
    protected FileSystemItem(string name)
    {
        Name = name;
    }
    
    public abstract int GetSize();
    public abstract void Display(int depth);
}

public class File : FileSystemItem
{
    private readonly int _size;
    
    public File(string name, int size) : base(name)
    {
        _size = size;
    }
    
    public override int GetSize() => _size;
    
    public override void Display(int depth)
    {
        var indent = new string(' ', depth * 2);
        Console.WriteLine($"{indent}📄 {Name} ({_size} bytes)");
    }
}

public class Directory : FileSystemItem
{
    private readonly List<FileSystemItem> _children = new();
    
    public Directory(string name) : base(name) { }
    
    public void Add(FileSystemItem item)
    {
        _children.Add(item);
    }
    
    public void Remove(FileSystemItem item)
    {
        _children.Remove(item);
    }
    
    public override int GetSize()
    {
        return _children.Sum(child => child.GetSize());
    }
    
    public override void Display(int depth)
    {
        var indent = new string(' ', depth * 2);
        Console.WriteLine($"{indent}📁 {Name}/");
        
        foreach (var child in _children)
        {
            child.Display(depth + 1);
        }
    }
}
