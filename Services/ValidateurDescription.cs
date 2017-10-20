using System.Globalization;
using System.Windows.Controls;

namespace Services
{
    public class ValidateurDescription : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (((string)value).Length >= 100)
                return new ValidationResult(false, "Le champ ne doit dépasser 100 caractères");

            return ValidationResult.ValidResult;
        }
    }
}
