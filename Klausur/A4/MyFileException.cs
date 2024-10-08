namespace A4;

public class MyFileException : Exception
{
    public MyFileException(string message, Exception innerException) 
        : base(message, innerException) { }
}