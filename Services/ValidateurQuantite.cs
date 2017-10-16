using System.Globalization;
using System.Windows.Controls;

namespace Services
{
    public class ValidateurQuantite : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int result;
            if (!int.TryParse(value.ToString(), out result))
                return new ValidationResult(false, "La quantité doit être un nombre");
            if((int)value < 0)
                return new ValidationResult(false, "La quantité ne peut pas être négative");
            return ValidationResult.ValidResult;
        }
    }
}