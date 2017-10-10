using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Affaire;

namespace Services
{
    public class ConvertisseurMois : IValueConverter
    {
        public object Convert(object value, Type targetType,
             object parameter, CultureInfo culture)
        {
            return Constantes.Mois[(int)value];
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return Array.FindIndex(Constantes.Mois, x => x.Contains((string)(value)));
        }
    }
}
