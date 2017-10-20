using System;
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
            int quantite = Convert.ToInt32(value);
            if( quantite < 0)
                return new ValidationResult(false, "La quantité ne peut pas être négative");
            if (value.ToString().Length == 0)
                return new ValidationResult(false, "Le champ ne peut être vide");
            return ValidationResult.ValidResult;
        }
    }
}