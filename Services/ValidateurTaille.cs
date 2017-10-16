using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Services
{
    public class ValidateurTaille : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            //char[] str = value.ToString().ToCharArray();
            //if (!char.IsUpper(str[0]))
            //    return new ValidationResult(false, "Le champ ne doit pas dépasser plus de 30 caractères");

            return ValidationResult.ValidResult;
        }
    }
}
