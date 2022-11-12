namespace VewTech.Net.Exceptions;

public class InvalidNameException : Exception
{
    public InvalidNameException() : base("Name is not valid.") { }
    public InvalidNameException(string message) : base(message) { }
}