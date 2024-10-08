namespace Studierendenverwaltung;

public class Student
{
    public string Namen { get; set; }
    public double[] Noten { get; set; }

    public Student(string namen, params double[] noten)
    {
        Namen = namen;
        Noten = noten;
    }

    public void AddGrades(double notenInput)
    {
        double[] cacheArray = new double[Noten.Length + 1];
        for (int i = 0; i < Noten.Length; i++)
        {
            cacheArray[i] = Noten[i];
        }

        cacheArray[cacheArray.Length - 1] = notenInput;
        Noten = cacheArray;

        string result = string.Join(" ,", Noten);
        Console.WriteLine(result);
        
    }
    
}