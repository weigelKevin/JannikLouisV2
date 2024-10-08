namespace A1;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int zahl = 6;

            if (zahl<5)
            {
            }
            else
            {
                try
                {
                    throw new InvalidOperationException();

                    try
                    {

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("innere Exception");
                    throw;
                }
            }
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("äußere Exception");
            throw;
        }
    }
    
}