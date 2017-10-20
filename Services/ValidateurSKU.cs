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

            if (new ScribeXML().recupererPlantes().ToList().Exists(x => x.SKU == ((string)value)))
                return new ValidationResult(false, "Le SKU du produit éxiste déjà");
            return ValidationResult.ValidResult;
        }
    }
}
