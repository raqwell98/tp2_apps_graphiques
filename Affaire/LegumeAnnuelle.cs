using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class LegumeAnnuelle : Legume
    {
        private string format;
        public LegumeAnnuelle() : base(){ format = ""; }
        public string Format { get => format; set {  format = value; OnPropertyChanged("Format"); } }
    }
}
