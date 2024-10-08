

using System.Runtime.Serialization;

namespace Exception3;

class DorianException:Exception
{
    public DorianException()
    {
    }

    protected DorianException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
       
    }

    public DorianException(string? message) : base(message)
    {
        message = "Dorian raised";
    }

    public DorianException(string? message, Exception? innerException) : base(message, innerException)
    {
        message = "Dorian was raised";
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            throw new DorianException();
        }
        catch (DorianException theDorian)
        {
            Console.WriteLine(theDorian.Message);
        }
    }
}