using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Services
{
    public class ValidateurChampRequis : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value.ToString() == "")
                return new ValidationResult(false, "Ce champs est requis");

            return ValidationResult.ValidResult;
        }
    }
}
