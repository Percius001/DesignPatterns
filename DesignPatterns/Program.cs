// See https://aka.ms/new-console-template for more information
// Abstract Factory Design Pattern 
using DesignPatterns.AbstractFactory;
//Builder Design Pattern
using DesignPatterns.Builder;

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


Console.ReadLine();
