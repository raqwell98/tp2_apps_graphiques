using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Affaire;

namespace Services
{
    public class ValidateurSKU : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int result;
            if (!int.TryParse(value.ToString(), out result))
                return new ValidationResult(false, "Le SKU doit être un nombre");
            if (new ScribeXML().recupererPlantes().ToList().Exists(x => x.SKU == ((string)value)))
                return new ValidationResult(false, "Le SKU du produit éxiste déjà");
            if (value.ToString().Length == 0)
                return new ValidationResult(false, "Le champ ne peut être vide");
            return ValidationResult.ValidResult;
        }
    }
}
