namespace Basics;

class Cat:Animal
{
    private string Katzenfutter { get; set; }
    
    public Cat(bool hasLegs, string k) : base(hasLegs)
    {
        this.Katzenfutter = k;
    }
}
