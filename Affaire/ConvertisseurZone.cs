using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Affaire
{
    public class ConvertisseurZone : IValueConverter
    {
        public object Convert(object value, Type targetType,
     object parameter, CultureInfo culture)
        {
            return Constantes.Zone.Noms[(int)value];
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return Array.FindIndex(Constantes.Zone.Noms, x => x.Contains((string)(value)));
        }
    }
}
