﻿using System.Globalization;
using System.Windows.Controls;

namespace Services
{
    public class ValidateurDescription : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            char[] str = value.ToString().ToCharArray();
            if (!(str.Length > 0 && str.Length <= 30))
                return new ValidationResult(false, "Le champ doit comporter entre 1 et 300 caractères");

            return ValidationResult.ValidResult;
        }
    }
}