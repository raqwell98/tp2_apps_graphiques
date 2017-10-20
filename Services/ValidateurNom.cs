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
            string valeur = (string)value;
            if(valeur != "")
            {
                if (!char.IsUpper(valeur[0]))
                    return new ValidationResult(false, "Le champ doit commencer par une lettre majuscule");
            }
            
            if (!(valeur.Length > 0 && valeur.Length <= 30))
                return new ValidationResult(false, "Le champ doit comporter entre 1 et 30 lettres");

            return ValidationResult.ValidResult;
        }
    }
}
