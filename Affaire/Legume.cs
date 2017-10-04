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

        public int TempsRecolte { get => tempsRecolte; set { OnPropertyChanged("TempsRecolte"); tempsRecolte = value; } }
        public int Type { get => type; set { OnPropertyChanged("Type"); type = value; } }
    }
}
