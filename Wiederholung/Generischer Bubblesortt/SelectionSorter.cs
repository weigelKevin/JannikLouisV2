namespace Generischer_Bubblesortt;

public class SelectionSorter<T> where T:IComparable<T>
{
    private List<T> List { get; set; }

    public SelectionSorter(List<T> list)
    {
        List = list;
    }

    public void Selectionsort()
    {
        for (int i = 0; i < List.Count; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < List.Count(); j++)
            {
                if (List[j].CompareTo(List[minIndex])<0)
                {
                    minIndex = j;
                }
            }

            T cache = List[minIndex];
            List[minIndex] = List[i];
            List[i] = cache;

        }

            string result = string.Join(" ,", List);
            Console.WriteLine(result);
        }
            
    }
    