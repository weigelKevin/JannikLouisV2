namespace Hash;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = new[] { 1, 2, 3, 4, 5,10, 6,100 };
        int[] arr2 = new[] { 1,10,6 };
        int[] hash = new int[arr1.Max()];
        bool isSubset = false;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (hash[arr1[i]] == 0)
            {
                hash[arr1[i]] = 1;
            }
        }

        for (int j = 0; j < arr2.Length; j++)
        {
            if (hash[arr2[j]] == 1)
            {
                hash[arr2[j]] = 2;
            }
            
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            if (hash[arr2[i]] == 2)
            {
                isSubset = true;
                continue;
            }
            else
            {
                isSubset = false;
                break;
            }
        }

        if (isSubset == true)
        {
            Console.WriteLine("Ist eine Teilmenge");
        }
        else
        {
            Console.WriteLine("ist keine Teilmenge");
        }

        
    }
}