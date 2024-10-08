namespace InterfaceSort;

public class SelectionSorter <T>:ISorter<T> where T:IComparable
{
    public T[] sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIdx = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j].CompareTo(array[minIdx])<0)
                {
                    minIdx = j;
                }
            }

            T cache = array[i];
            array[i] = array[minIdx];
            array[minIdx] = cache;
        }

        return array;
    }
}