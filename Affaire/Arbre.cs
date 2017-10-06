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
        public int TempsTaille { get => tempsTaille; set {  tempsTaille = value; OnPropertyChanged("TempsTaille"); } }
        public int TypeTaille { get => typeTaille; set {  typeTaille = value; OnPropertyChanged("TypeTaille"); } }
        public int Zone { get => zone; set {  zone = value; OnPropertyChanged("Zone"); } }

    }
}
