# 🎯 Design Patterns in C# - POC Project

A comprehensive demonstration of software design patterns implemented in C# with practical examples and real-world scenarios.

## 🏗️ Project Overview

This project showcases 12 essential design patterns organized into three main categories:

- **Creational Patterns**: Focus on object creation mechanisms
- **Structural Patterns**: Deal with object composition and relationships
- **Behavioral Patterns**: Handle communication between objects

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022, VS Code, or any C# IDE

### Running the Project
```bash
# Navigate to the project directory
cd DesignPatterns

# Build the project
dotnet build

# Run the application
dotnet run
```

## 📚 Design Patterns Covered

### 🏗️ Creational Patterns

#### 1. **Factory Pattern** (`FactoryPatternDemo.cs`)
- **Purpose**: Creates objects without specifying their exact classes
- **Example**: Vehicle factory creating different types of vehicles (Car, Motorcycle, Truck)
- **Use Case**: When you need to create objects based on runtime conditions

#### 2. **Singleton Pattern** (`SingletonPatternDemo.cs`)
- **Purpose**: Ensures a class has only one instance and provides global access
- **Example**: Configuration manager with thread-safe lazy initialization
- **Use Case**: Managing global resources like configuration, logging, or database connections

#### 3. **Builder Pattern** (`BuilderPatternDemo.cs`)
- **Purpose**: Constructs complex objects step by step
- **Example**: Computer builder with fluent interface
- **Use Case**: Creating objects with many optional parameters or complex construction logic

#### 4. **Abstract Factory Pattern** (`AbstractFactoryPatternDemo.cs`)
- **Purpose**: Creates families of related objects
- **Example**: UI component factories for different operating systems
- **Use Case**: When you need to ensure compatibility between related objects

### 🏛️ Structural Patterns

#### 5. **Adapter Pattern** (`AdapterPatternDemo.cs`)
- **Purpose**: Allows incompatible interfaces to work together
- **Example**: Legacy payment system adapter for modern payment processor
- **Use Case**: Integrating third-party libraries or legacy systems

#### 6. **Decorator Pattern** (`DecoratorPatternDemo.cs`)
- **Purpose**: Adds behavior to objects dynamically
- **Example**: Coffee ordering system with customizable add-ons
- **Use Case**: Adding features to objects without modifying their classes

#### 7. **Facade Pattern** (`FacadePatternDemo.cs`)
- **Purpose**: Provides a simplified interface to a complex subsystem
- **Example**: Home automation system with predefined routines
- **Use Case**: Simplifying complex system interactions for clients

#### 8. **Composite Pattern** (`CompositePatternDemo.cs`)
- **Purpose**: Treats individual objects and compositions uniformly
- **Example**: File system structure with files and directories
- **Use Case**: Representing part-whole hierarchies

### 🧠 Behavioral Patterns

#### 9. **Observer Pattern** (`ObserverPatternDemo.cs`)
- **Purpose**: Defines a one-to-many dependency between objects
- **Example**: Weather station with multiple display devices
- **Use Case**: Implementing event handling systems and notifications

#### 10. **Strategy Pattern** (`StrategyPatternDemo.cs`)
- **Purpose**: Defines a family of algorithms and makes them interchangeable
- **Example**: Payment processing with different payment methods
- **Use Case**: When you have multiple algorithms for the same task

#### 11. **Command Pattern** (`CommandPatternDemo.cs`)
- **Purpose**: Encapsulates a request as an object
- **Example**: Smart home remote control system
- **Use Case**: Implementing undo/redo functionality and queuing operations

#### 12. **Chain of Responsibility Pattern** (`ChainOfResponsibilityPatternDemo.cs`)
- **Purpose**: Passes requests along a chain of handlers
- **Example**: Support ticket escalation system
- **Use Case**: Processing requests that can be handled by multiple objects

## 🎨 Project Structure

```
DesignPatterns/
├── Program.cs                          # Main entry point
├── Creational/                        # Creational patterns
│   ├── FactoryPatternDemo.cs
│   ├── SingletonPatternDemo.cs
│   ├── BuilderPatternDemo.cs
│   └── AbstractFactoryPatternDemo.cs
├── Structural/                        # Structural patterns
│   ├── AdapterPatternDemo.cs
│   ├── DecoratorPatternDemo.cs
│   ├── FacadePatternDemo.cs
│   └── CompositePatternDemo.cs
└── Behavioral/                        # Behavioral patterns
    ├── ObserverPatternDemo.cs
    ├── StrategyPatternDemo.cs
    ├── CommandPatternDemo.cs
    └── ChainOfResponsibilityPatternDemo.cs
```

## 🔍 Key Features

- **Real-world Examples**: Each pattern demonstrates practical use cases
- **Clear Documentation**: Comprehensive comments explaining pattern implementation
- **Interactive Output**: Console-based demonstrations with visual feedback
- **Modern C#**: Uses latest C# features like pattern matching, nullable reference types
- **SOLID Principles**: Follows software design best practices

## 💡 Learning Benefits

- **Understanding**: See how design patterns solve common software problems
- **Implementation**: Learn proper C# implementation techniques
- **Application**: Discover when and where to use each pattern
- **Best Practices**: Follow industry-standard coding practices

## 🎯 Target Audience

- **Software Developers**: Learning or refreshing design pattern knowledge
- **Students**: Computer science and software engineering students
- **Interview Preparation**: Common design pattern questions in technical interviews
- **Code Review**: Reference for implementing patterns in production code

## 🔧 Customization

Feel free to:
- Modify examples to match your domain
- Add new patterns
- Enhance existing implementations
- Create unit tests for each pattern

## 📖 Additional Resources

- [Gang of Four Design Patterns](https://en.wikipedia.org/wiki/Design_Patterns)
- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Refactoring Guru - Design Patterns](https://refactoring.guru/design-patterns)

## 🤝 Contributing

Contributions are welcome! Please feel free to submit issues, feature requests, or pull requests.

---

**Happy Coding! 🚀**
