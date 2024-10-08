namespace A3;
 
 class CMath<T>
 {
     public T Value { get; set; }
 }
 class Program
 {
     static void Main(string[] args)
     {
         CMath<string> Num1 = new CMath<string>();
         Num1.Value = "eins";
         
         CMath<int> Num2 = new CMath<int>();
         Num2.Value = 1;
         
         CMath<double> Num3 = new CMath<double>();
         Num3.Value = 3.5;
         Console.WriteLine($"String Num: {Num1.Value}, int Num: {Num2.Value}, double Num: {Num3.Value}");
     }
 }