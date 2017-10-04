using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Arbre : Plante
    {
        private int tempsTaille;
        private int typeTaille;
        private int zone;

        public Arbre() : base() { tempsTaille = 0; typeTaille = 0; zone = 0; }
        public int TempsTaille { get => tempsTaille; set { OnPropertyChanged("TempsTaille"); tempsTaille = value; } }
        public int TypeTaille { get => typeTaille; set { OnPropertyChanged("TypeTaille"); typeTaille = value; } }
        public int Zone { get => zone; set { OnPropertyChanged("Zone"); zone = value; } }

    }
}
