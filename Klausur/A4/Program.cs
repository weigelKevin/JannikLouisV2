using System.Runtime.InteropServices.JavaScript;

namespace A4;

class Program
{
    static void Main()
    {
        try
        {
            var myObject = new CMyClass();
            StreamReader file = myObject.OpenFile("myFile.txt");
        }
        catch (MyFileException ex)
        {
            Console.WriteLine($"Custom Exception Caught: {ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
            }
        }
    }
}

class CMyClass
{
    public StreamReader OpenFile(string fileName)
    {
        try
        {
            // Versuche, die Datei zu öffnen
            return File.OpenText(fileName);
        }
        catch (FileNotFoundException ex)
        {
            // Wirf eine benutzerdefinierte Exception mit innerer Exception
            throw new MyFileException($"File '{fileName}' could not be found.", ex);
        }
    }
}
