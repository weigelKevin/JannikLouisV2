using System.Collections;

namespace OddNumberIterator;

public class OddNumIter:IEnumerable<int>
{
    
    public int Max { get; set; }
    public static uint counter { get; set; }

    public OddNumIter(int max)
    {
        Max = max;
        counter++;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < Max; i++)
        {
            if (i%2 == 0)
            {
                continue;
            }
            else
            {
                yield return i;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}