namespace Fahrzeugverleih;

class Program
{
    static void Main(string[] args)
    {
        Fahrzeugverleih v1 = new Fahrzeugverleih("A", 30);
        Fahrzeugverleih v2 = new Fahrzeugverleih("B", 30);
        Fahrzeugverleih v3 = new Fahrzeugverleih("C", 30);
        Fahrzeugverleih v4 = new Fahrzeugverleih("D", 30);
        Fahrzeugverleih v5 = new Fahrzeugverleih("E", 30);

        Fahrzeugverleih[] array = new Fahrzeugverleih[]
        {
            v1,
            v2,
            v3,
            v4,
            v5,
        };
        foreach (var obj in array)
        {
            Console.WriteLine(obj.ToString());
        }


    }
}