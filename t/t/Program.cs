using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security.Authentication;

namespace t;

class t
{
    
}

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

            try
            {
                if (i == 3)
                {
                    throw new InvalidCredentialException("ich bin ein fehler 2");
                }
            }
            catch (InvalidCredentialException e)
            {
                
            }
        }
        catch (DorianException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.HResult);
            Console.WriteLine(e.InnerException);
        }
    }
}