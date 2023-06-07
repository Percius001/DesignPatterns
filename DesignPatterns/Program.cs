// See https://aka.ms/new-console-template for more information
// Abstract Factory Design Pattern 
using DesignPatterns.AbstractFactory;
//Builder Design Pattern
using DesignPatterns.Builder;
//Factory Method Design Pattern
using DesignPatterns.Factory;
//Prototype Design Pattern
using DesignPatterns.Prototype;
//Singleton Design Pattern
using DesignPatterns.Singleton;

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

//Prototype Design Pattern
Console.WriteLine("\n-----Prototype Design Pattern-----");
ColorManager colormanger = new ColorManager();
colormanger["red"] = new Color(255, 0, 0);
colormanger["peace"] = new Color(255,255,255);

Color? color1 = colormanger["peace"].Clone() as Color;

//Singleton Design Pattern
Console.WriteLine("\n-----Singleton Design Pattern-----");
var b1 = LoadBalancer.GetLoadBalancer();
var b2 = LoadBalancer.GetLoadBalancer();

if(b1 == b2)
{
    Console.WriteLine("Same Instance");
}

LoadBalancer loadBalancer = LoadBalancer.GetLoadBalancer();
for(int i = 0; i < 10; i++)
{
    string serverName = loadBalancer.NextServer.Name;
    Console.WriteLine("Dispatch request to: " + serverName);
}

Console.ReadLine();
