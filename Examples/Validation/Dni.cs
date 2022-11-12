using VewTech.Net.Exceptions;
using VewTech.Net.Validation;

namespace VewTech.Net.Examples.Validation
{
    internal static class Dni
    {
        internal static void Run(string dniToValidate)
        {
            try
            {
                DniValidator.Validate(dniToValidate);
            }
            catch (InvalidDniException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
