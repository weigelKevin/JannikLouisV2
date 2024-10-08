using System.Runtime.CompilerServices;

namespace Basics;

abstract class Animal
{
    public bool hasLegs { get; set; }
    public Animal(bool hasLegs)
    {
        this.hasLegs = hasLegs;
    }
  
    public bool GetLegs()
    {
        return this.hasLegs;
    }
}
class Dog : Animal,DummyDog
{
    public string hundefutter { get; set; }

    public Dog(bool hasLegs, string Hundefutter) : base(hasLegs)
    {
        this.hundefutter = Hundefutter;
    }

    public void GetLegs()
    {
        throw new NotImplementedException();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog d1 = new Dog(true, "Dorian");
        Console.WriteLine(d1.hundefutter);
        Cat c1 = new Cat(false,"Dorian");
        Console.WriteLine(c1.hasLegs);
    }
}