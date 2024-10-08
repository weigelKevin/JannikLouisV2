namespace Generischer_Bubblesortt;

public class Bubblesorter<T> where T : IComparable
{
    private List<T> List { get; set; }

    public Bubblesorter(List<T> list)
    {
        List = list;
    }

    public void Bubblesort()
    {
        for (int i = 0; i < List.Count-1; i++)
        {
            for (int j = 0; j < List.Count()-1-i; j++)
            {
                if (List[j].CompareTo(List[j+1])>0)
                {
                    T cache = List[j + 1];
                    List[j + 1] = List[j];
                    List[j] = cache;
                }
            }

            string result = string.Join(" ,", List);
            Console.WriteLine(result);
        }
            
    }
       

    }
