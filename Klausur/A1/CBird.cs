namespace A1;

public class CBird:CAnimal
{
    public CBird(bool hasWings, int noOfLegs = 2) : base(hasWings, noOfLegs)
    {
        this.NoOfLegs = 2;
    }

    //sadjjfalöksejfklö
    public void Hatch()
    {
        Console.WriteLine("Hatching....");
    }
}