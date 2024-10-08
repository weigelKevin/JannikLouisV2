using System.Runtime.Serialization;

namespace Bubblesort;


class DorianDerÜbermenschError:Exception
{
    public DorianDerÜbermenschError():base("Lil Dick boy appeared")
    {
        this.HelpLink = "https://archive.org/details/vbt-2015-dorian-der-ubermensch-vorrunde-1-vs.-ni.-k.-o";
        
    }

    protected DorianDerÜbermenschError(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public DorianDerÜbermenschError(string? message) : base(message)
    {
        
    }

    public DorianDerÜbermenschError(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
class Program
{

    public static void Main(string[] args)
    {

        try
        {
            int x = 1;
            if (x == 1)
            {
                throw new DorianDerÜbermenschError();
            }
        }
        catch (DorianDerÜbermenschError e)
        {
            Console.WriteLine($"{e.Message}\n{e.StackTrace}\n{e.HelpLink}\n{e.HResult}");
            
            
        }
    }
}