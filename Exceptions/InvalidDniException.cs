namespace VewTech.Net.Exceptions
{
    public class InvalidDniException : Exception
    {
        public InvalidDniException() : base("Input DNI is invalid.") {}
        public InvalidDniException(string message) : base(message) {}
    }
}