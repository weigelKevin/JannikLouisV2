namespace CountToTen;

class Program
{
    static IEnumerable<int> CountToTen()
    {
        for (int i = 0; i < 11; i++)
        { 
            yield return i;
        }
    }
    static void Main(string[] args)
    {
        string ergeb = string.Join(" ,", CountToTen().Take(5));
        Console.WriteLine(ergeb);

    }
}