using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Utilisateurs
{
    public class ValidateurTelephone : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string telephone = value.ToString();
            string pattern = @"\b\d{3}[-.]?\d{3}[-.]?\d{4}\b";
            Match result = Regex.Match(telephone, pattern);

            if (!result.Success)
                return new ValidationResult(false, "Vous devez entrer un numéro de téléphone valide (ex: 555-555-5555)");

            return ValidationResult.ValidResult;
        }
    }
}