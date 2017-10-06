using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Globalization;

namespace Services
{
    public class ValidateurNom : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            char[] str = value.ToString().ToCharArray();
            if (!char.IsUpper(str[0]))
                return new ValidationResult(false, "Le nom doit commencer par une lettre majuscule");

            return ValidationResult.ValidResult;
        }
    }
}
