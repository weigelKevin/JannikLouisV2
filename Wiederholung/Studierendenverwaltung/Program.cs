namespace Studierendenverwaltung;

class Program
{
    static void Main(string[] args)
    {
        Student st1 = new Student("Peter", 1,2);
        st1.AddGrades(3);
    }
}