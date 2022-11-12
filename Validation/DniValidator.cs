using VewTech.Net.Exceptions;

namespace VewTech.Net.Validation
{
    public static class DniValidator
    {
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
        }
    }
}