namespace Rekursion;

class Program
{
    private List<int> result = new List<int>();
    public void EvenArray( int counter, params int[] arr)
    {
        
        if (counter>=arr.Length)
        {
            return;
        }

        if (arr[counter] % 2 == 0)
        {
            result.Add(arr[counter]);
        }

        counter++;
        EvenArray(counter,arr);
    }
    static void Main(string[] args)
    {

        Console.WriteLine(Math.Log10(2));
        Console.WriteLine(Math.Log10(20));
    }
}