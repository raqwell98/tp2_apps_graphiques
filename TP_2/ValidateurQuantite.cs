using System.Globalization;
using System.Windows.Controls;

namespace TP_2
{
    public class ValidateurQuantite : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int result;
            if (!int.TryParse(value.ToString(), out result))
                return new ValidationResult(false, "La masse doit être un nombre");

            return ValidationResult.ValidResult;
        }
    }
}