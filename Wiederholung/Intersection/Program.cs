namespace Intersection;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4,400, 5, 1000 };
        int[] arr2 = { 2, 3, 5,399 };
        int[] hashTable = new int[arr1.Max()];
        bool isInterElement = false;

        for (int i = 0; i < arr1.Length-1; i++)
        {
            hashTable[arr1[i]] = 1;
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            if (hashTable[arr2[i]] == 1)
            {
                hashTable[arr2[i]] = 2;
            }
            else
            {
                hashTable[arr2[i]] = 1;
            }
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            if (hashTable[arr2[i]]==2)
            {
                isInterElement = true;
                continue;
            }
            else
            {
                isInterElement = false;
                break;
            }
        }

        if (isInterElement == true)
        {
            Console.WriteLine("Ist eine Teilmenge");
        }
        else
        {
            Console.WriteLine("Ist keine Teilmenge");
        }
    }
}