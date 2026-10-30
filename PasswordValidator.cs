using dz_8;
using System.Text.RegularExpressions;

namespace dz_8
{
    public class PasswordValidator : IValidator
    {
        public bool Validate(string input)
        {
            return !string.IsNullOrEmpty(input) && input.Length >= 6;
        }
    }

    public class EmailValidator : IValidator
    {
        public bool Validate(string input)
        {
            return !string.IsNullOrEmpty(input) && input.Contains("@") && input.Contains(".");
        }
    }
}