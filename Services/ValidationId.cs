using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Affaire;
using System.Windows.Data;

namespace Services
{
    public class ValidationId : ValidationRule
    {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingGroup bindingGroup = (BindingGroup)value;
            Affaire.Connexion con = (Affaire.Connexion)bindingGroup.Items[0];
            if (Constantes.Utilisateur.estValide(con.Utilisateur.Identifiant))
            {
                return new ValidationResult(true, null);
            }
            return new ValidationResult(false,
                      "Cet identifiant n'existe pas.");
        }
    }
}
