using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Services
{
    public class ValidateurCodePostal : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string codePostal = (string)value;
            string pattern = @"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]";
            Match result = Regex.Match(codePostal, pattern);

            if (!result.Success)
                return new ValidationResult(false, "Vous devez entrer un code postal valide (ex: A1A 1A1)");
            if(codePostal.Length == 0)
                return new ValidationResult(false, "Le champ ne peut être vide");

            return ValidationResult.ValidResult;
        }
    }
}