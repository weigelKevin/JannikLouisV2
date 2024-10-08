namespace InterfaceSort;

public class BubbleSorter<T> : ISorter<T> where T:IComparable
{
    public T[] sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length-1; j++)
            {
                if (array[j].CompareTo(array[j+1])>0)
                {
                    T cache = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = cache;
                }
            }
        }

        return array;


    }
}