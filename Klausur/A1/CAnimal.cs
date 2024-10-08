namespace A1;

public class CAnimal
{
    public bool HasWings { get; set; }
    public int NoOfLegs { get; set; }

    public CAnimal(bool hasWings, int noOfLegs)
    {
        HasWings = hasWings;
        NoOfLegs = noOfLegs;
    }

    //KLAJFlköjsdlökfjklö
    public void Move() 
    {
        Console.WriteLine("Moved");
    }
}