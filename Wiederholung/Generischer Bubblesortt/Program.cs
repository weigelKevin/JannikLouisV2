namespace Generischer_Bubblesortt;

class Program
{
    static void Main(string[] args)
    {
        Bubblesorter<int> b1 = new Bubblesorter<int>([1, 2, 0, 5, 3, 10, 9]);
        SelectionSorter<int> s1 = new SelectionSorter<int>([1, 2, 0, 5, 3, 10, 9]);

        
        s1.Selectionsort();
        
        
    }
}