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
    class ValidateurSKU : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            CollectionPlantesObservable plantes = new ScribeXML().recupererPlantes();
            bool existeSKU = false;
            try
            {
                if (plantes.ToList().First(x => x.SKU == ((string)value)) != null)
                    existeSKU = true;
            }
            catch (Exception e) { }
            if (existeSKU)
                return new ValidationResult(false, "Le SKU du produit éxiste déjà");
            return ValidationResult.ValidResult;
        }
    }
}
