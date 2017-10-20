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
    public class ValidateurId : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int result;
            if (!int.TryParse(value.ToString(), out result))
                return new ValidationResult(false, "L'id doit être un nombre");
            if (new ScribeXML().recupererClients().ToList().Exists(x => x.Id == ((string)value)))
                return new ValidationResult(false, "L'id de client éxiste déjà");
            if (value.ToString().Length == 0)
                return new ValidationResult(false, "Le champ ne peut être vide");
            return ValidationResult.ValidResult;
        }
    }
}
