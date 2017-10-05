using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class FleurAnnuelle : Plante
    {
        private string format;
        public FleurAnnuelle() { format = ""; }
        public string Format { get => format; set { OnPropertyChanged("Format"); format = value; } }
    }
}
