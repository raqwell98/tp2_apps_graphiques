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
    class ValidateurId : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            CollectionClientsObservable clients = new ScribeXML().recupererClients();
            if (clients.ToList().First(x => x.Id == ((string)value)) == null)
                return ValidationResult.ValidResult;
            return new ValidationResult(false, "L'id de client éxiste déjà");
        }
    }
}
