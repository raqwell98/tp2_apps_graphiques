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
    public class ConvertisseurZone : IValueConverter
    {
        public object Convert(object value, Type targetType,
     object parameter, CultureInfo culture)
        {
            return Constantes.Zones[(int)value];
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return Array.FindIndex(Constantes.Zones, x => x.Contains((string)(value)));
        }
    }
}
