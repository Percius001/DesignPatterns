// See https://aka.ms/new-console-template for more information
// Abstract Factory Design Pattern 
using DesignPatterns.AbstractFactory;


// Abstract Factory Design Pattern 
AnimalWorld americaAnimalWorld = new AnimalWorld(new America());
AnimalWorld africaAnimalWorld = new AnimalWorld(new Africa());
americaAnimalWorld.RunFoodChain();
africaAnimalWorld.RunFoodChain();


Console.ReadLine();
