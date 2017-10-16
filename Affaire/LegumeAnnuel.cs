using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class LegumeAnnuel : Legume
    {
        private string format;
        public LegumeAnnuel() : base(){ format = ""; }
        public string Format { get => format; set {  format = value; OnPropertyChanged("Format"); } }
    }
}
