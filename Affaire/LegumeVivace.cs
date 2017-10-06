using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class LegumeVivace : Legume
    {
        private int zone;
        public LegumeVivace() : base(){ zone = 0; }
        public int Zone { get => zone; set {  zone = value; OnPropertyChanged("Zone"); } }
    }
}
