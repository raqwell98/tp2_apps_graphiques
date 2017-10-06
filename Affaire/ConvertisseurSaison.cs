﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Affaire
{
    public class ConvertisseurSaison : IValueConverter
    {
        public object Convert(object value, Type targetType,
             object parameter, CultureInfo culture)
        {
            return Constantes.Saison.Noms[(int)value];
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return Array.FindIndex(Constantes.Saison.Noms, x => x.Contains((string)(value)));
        }
    }
}