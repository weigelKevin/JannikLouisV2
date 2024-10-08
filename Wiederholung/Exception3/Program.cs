using System.Runtime.Serialization;

namespace Exception3;


class DorianException : Exception
{
    public DorianException()
    {
    }

    protected DorianException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public DorianException(string? message) : base(message)
    {
    }

    public DorianException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        int i = 3;
        try
        {
            if (i == 3)
            {
                throw new DorianException("ich bin ein fehler");
            }
        }
        catch (DorianException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}