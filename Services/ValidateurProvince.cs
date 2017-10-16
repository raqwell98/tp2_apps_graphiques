using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Utilisateurs
{
    public class ValidateurProvince : ValidationRule 
    {
        private List<string> provinces = new List<string>() { "Terre-Neuve", "Québec", "Ontario", "Alberta", "Colombie-Britannique", "Manitoba", "Nouveau-Brunswick", "Nouvelle-Écosse", "Île-du-Prince-Édouard", "Saskatchewan" };
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string province = value.ToString();
            if (!provinces.Contains(province))
                return new ValidationResult(false, "Vous devez entrer une province du Canada");

            return ValidationResult.ValidResult;
        }
    }
}