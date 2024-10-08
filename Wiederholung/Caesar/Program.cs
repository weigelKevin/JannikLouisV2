namespace Caesar;

class Program
{
    static void Main(string[] args)
    {
        bool checkSwitch = true;
        string alphabetString = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] alphaArray = alphabetString.ToCharArray();
        Console.WriteLine("Hello, User");
        Console.WriteLine("Please enter only uppercase in range of A-Z");
        string? input = Console.ReadLine();
        char[] inputArr = input.ToCharArray();

        for (int i = 0; i <inputArr.Length ; i++)
        {
            if (checkSwitch == false)
            {
                break;
            }
            for (int j = 0; j < alphaArray.Length; j++)
            {
                if (inputArr[i] != alphaArray[j])
                {
                    checkSwitch = false;
                    continue;
                }
                else
                {
                    checkSwitch = true;
                    break;
                }
                
            }
        }

        if (checkSwitch == false)
        {
            Console.WriteLine("nicht im alphabet");
        }

        Console.WriteLine("Gib rotation ein");
        int n = int.Parse(Console.ReadLine());

      

        for (int i = 0; i < inputArr.Length; i++)
        {
            for (int j = 0; j < alphaArray.Length; j++)
            {
                if (inputArr[i] == alphaArray[j])
                {
                    inputArr[i] = alphaArray[j + n];
                    
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        string result = string.Join(" ,", inputArr);
        Console.WriteLine(result);




    }
}