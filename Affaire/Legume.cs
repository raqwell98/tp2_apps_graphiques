using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Legume : Plante
    {
        private int tempsRecolte;
        private int type;

        public Legume() : base() { tempsRecolte = 0; type = 0; }

        public int TempsRecolte { get => tempsRecolte; set {  tempsRecolte = value; OnPropertyChanged("TempsRecolte"); } }
        public int Type { get => type; set {  type = value; OnPropertyChanged("Type"); } }
    }
}
