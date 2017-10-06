using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Affaire;
using System.Windows.Data;

namespace TP_2
{
    public class ValidationId : ValidationRule
    {

        public ValidationId()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingGroup bindingGroup = (BindingGroup)value;
            Affaire.Connexion con = (Affaire.Connexion)bindingGroup.Items[0];
            if (Constantes.Utilisateur.estValide(con.Utilisateur.Identifiant))
            {
                return new ValidationResult(true, null);
            }
            return new ValidationResult(false,
                      "Cette identifiant n'existe pas.");

        }
    }
}
