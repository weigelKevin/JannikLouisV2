namespace OddNumberIterator;

class Program
{
    static void Main(string[] args)
    {
        OddNumIter od1 = new OddNumIter(4);
        OddNumIter od2 = new OddNumIter(4);
        OddNumIter od3 = new OddNumIter(4);
        
        foreach (var iter in od1)
        {
            
            Console.WriteLine(OddNumIter.counter);
        }
    }
}