using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Services
{
    public class ValidateurCourriel : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string email = value.ToString();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
                return new ValidationResult(false, "Vous devez entrer une adresse courriel valide (ex: adambernard@gmail.com)");
            if (email.Length == 0)
                return new ValidationResult(false, "Le champ ne peut être vide");

            return ValidationResult.ValidResult;
        }
    }
}