namespace Palindrom;


class Program
{
    static void Main(string[] args)
    {
        greet g1 = new greet();
        Console.WriteLine("Hello, World!");
        Console.WriteLine(g1.DoGreet());
        string? input1 = Console.ReadLine();
        g1.DoCheckInput(input1);
        g1.CheckIfPalindrom(input1);
        g1.CheckIfPalindromV2(input1);
        
        

            


    }

   
}