using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class FleurVivace : Plante
    {
        private int zone;
        public FleurVivace() : base(){ zone = 0;  }
        public int Zone { get => zone; set { OnPropertyChanged("Zone"); zone = value; } }
    }
}
