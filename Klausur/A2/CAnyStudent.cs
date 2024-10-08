namespace A2;

abstract class CAnyStudent:DummyAnyStudent
{
    private int Urlaubs_Ferientage { get; set; }

    public CAnyStudent(int urlaubsFerientage)
    {
        Urlaubs_Ferientage = urlaubsFerientage;
    }


    public int GetHolidays()
    {
        return Urlaubs_Ferientage;
    }
}

class DHBWStudent : IDHBWStudent
{
    private int Urlaubs_Ferientage { get; set; }

    public DHBWStudent(int urlaubsFerientage)
    {
        Urlaubs_Ferientage = urlaubsFerientage;
    }

    public int GetHolidays()
    {
        return Urlaubs_Ferientage;
    }
    
}

class FHStudent : IFHStudent
{
    private int Urlaubs_Ferientage { get; set; }

    public FHStudent(int urlaubsFerientage)
    {
        Urlaubs_Ferientage = urlaubsFerientage;
    }

    public int GetHolidays()
    {
        return Urlaubs_Ferientage;
    }
}