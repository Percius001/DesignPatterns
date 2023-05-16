// See https://aka.ms/new-console-template for more information
// Abstract Factory Design Pattern 
using DesignPatterns.AbstractFactory;
//Builder Design Pattern
using DesignPatterns.Builder;
//Factory Method Design Pattern
using DesignPatterns.Factory;

// Abstract Factory Design Pattern 
Console.WriteLine("-----Abstract Design Pattern-----");
AnimalWorld americaAnimalWorld = new AnimalWorld(new America());
AnimalWorld africaAnimalWorld = new AnimalWorld(new Africa());
americaAnimalWorld.RunFoodChain();
africaAnimalWorld.RunFoodChain();

//Builder Design Pattern
Console.WriteLine("\n-----Builder Design Pattern-----");
VehicleBuilder builder;
Shop shop = new Shop();
builder = new CarBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

builder = new MotorcycleBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

//Factory Method Design Pattern
Console.WriteLine("\n-----Factory Method Design Pattern-----");
Presentation[] presentations = new Presentation[2];
presentations[0] = new FirstSilde();
presentations[1] = new SecondSlide();

foreach(var presentation in presentations)
{
    Console.WriteLine(presentation.GetType().Name+":");
    foreach(var section in presentation.Sections)
    {
        Console.WriteLine(section.GetType().Name);
    }
    Console.WriteLine();
}


Console.ReadLine();
