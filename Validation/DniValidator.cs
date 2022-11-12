using VewTech.Net.Exceptions;

namespace VewTech.Net.Validation;

public static class DniValidator
{
    private static readonly Dictionary<int, char> DniLetters = new()
    {
        { 0, 'T' },
        { 1, 'R' },
        { 2, 'W' },
        { 3, 'A' },
        { 4, 'G' },
        { 5, 'M' },
        { 6, 'Y' },
        { 7, 'F' },
        { 8, 'P' },
        { 9, 'D' },
        { 10, 'X' },
        { 11, 'B' },
        { 12, 'N' },
        { 13, 'J' },
        { 14, 'Z' },
        { 15, 'S' },
        { 16, 'Q' },
        { 17, 'V' },
        { 18, 'H' },
        { 19, 'L' },
        { 20, 'C' },
        { 21, 'K' },
        { 22, 'E' }
    };

    /// <summary>
    /// <para>Throws an InvalidDni exception with the invalidity reason as the message if DNI is invalid.</para>
    /// <example>
    /// For example:
    /// <code>
    /// try{
    ///     Validate()
    /// catch (InvalidDniException e){
    ///     Debug.Write(e.Message);
    /// }
    /// </code>
    /// Will output the reason why this DNI is invalid, or give no output if it is valid.
    /// </example>
    /// </summary>
    public static void Validate(string dniToValidate)
    {
        if (string.IsNullOrEmpty(dniToValidate))
        {
            throw new InvalidDniException("DNI can't be empty.");
        }

        if (dniToValidate.Length != 9)
        {
            throw new InvalidDniException("DNI must have 9 characters");
        }

        if (int.TryParse(dniToValidate[8].ToString(), out _))
        {
            throw new InvalidDniException("DNI must end with a letter.");
        }

        var dniNoLetter = dniToValidate.Remove(8);
        if (!int.TryParse(dniNoLetter, out var dniNumeric))
        {
            throw new InvalidDniException("First 8 characters of DNI must be numeric.");
        }

        var correctLetter = DniLetters[dniNumeric % 23];
        if (dniToValidate[8] != correctLetter)
        {
            throw new InvalidDniException();
        }
    }
}