namespace Script;

class Generik<T> where T:IComparable
{

  public static int[] array = new int[] { 1, 2, 3, 4 };
  public int zahl1 { get; set; }
  public T zahl2 { get; set; }
  
  public Generik(int zahl1, T zahl2)
  {
    this.zahl1 = zahl1;
    this.zahl2 = zahl2;
  }

  public static int operator +(Generik<T> obj1, Generik<T> obj2)
  {
    
    return (obj1.zahl1 + obj2.zahl1);
  }
 
  
}