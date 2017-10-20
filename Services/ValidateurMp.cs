using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Affaire;
using System.Windows.Controls;
using System.Globalization;
using System.Windows.Data;

namespace Services
{
    public class ValidateurMp : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingGroup bindingGroup = (BindingGroup)value;
            Affaire.Connexion con = (Affaire.Connexion)bindingGroup.Items[0];

            if (Constantes.MotDePasse.estValide(con.MotDePasse))
            {
                return new ValidationResult(true, null);
            }
            return new ValidationResult(false,
                      "Mot de passe incorrect.");

        }
    }
}
