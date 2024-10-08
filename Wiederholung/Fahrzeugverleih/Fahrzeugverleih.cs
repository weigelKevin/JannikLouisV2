namespace Fahrzeugverleih;

public class Fahrzeugverleih
{
    public string ID { get; set; }
    private double Rental { get; set; }

    public Fahrzeugverleih(string id, double rental)
    {
        ID = id;
        Rental = rental;
    }

    public double CalculateRental(int days)
    {
        return days * Rental;
    }

    public override string ToString()
    {
        return $"ID: {ID}\nRental: {Rental}";
    }
}