namespace InterfaceSort;


class Program
{
    static void Main(string[] args)
    {
        BubbleSorter<int> BubbleSort = new BubbleSorter<int>();
        SelectionSorter<int> SelectionSortt = new SelectionSorter<int>();
        
        int[] bubergeb = BubbleSort.sort([3,2,1,0,10,8,5]);
        int[] selergeb = SelectionSortt.sort([3, 2, 1, 0, 10, 8, 5]);

        string b = string.Join(" ,", bubergeb);
        string s = string.Join(" ,", selergeb);
        Console.WriteLine(b);
        Console.WriteLine(s);


    }
}