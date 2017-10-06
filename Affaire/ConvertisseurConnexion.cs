using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Affaire
{
    public class ConvertisseurConnexion : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return (bool)value ? "Deconnexion" : "Connexion";
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            switch ((string)value)
            {
                case "Connexion":
                    return true;
                default:
                    return false;
            }
        }
    }
}
