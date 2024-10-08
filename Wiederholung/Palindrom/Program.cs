namespace Wiederholung;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte gebe einen String ein");
        string? input = Console.ReadLine();
        char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        char[] reversedArray = inputArray;
        string reversed = new string(reversedArray);

        if (input == reversed)
        {
            Console.WriteLine("passt");
        }
        else
        {
            Console.WriteLine("Passt nicht");
        }




    }
}