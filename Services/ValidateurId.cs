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
            CollectionClientsObservable clients = new ScribeXML().recupererClients();
            bool existeId = false;
            try
            {
                if (clients.ToList().First(x => x.Id == ((string)value)) != null)
                    existeId = true;
            } catch (Exception e) { }
            if (existeId)
                return new ValidationResult(false, "L'id de client éxiste déjà");
            return ValidationResult.ValidResult;
        }
    }
}
