using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public abstract class Plante : Produit
    {

        private TempsFloraison tfloraison;
        private int exposition;
        private int typeTerre;

        public Plante() : base() { tfloraison = new TempsFloraison(); exposition = 0; typeTerre = 0; }

        public TempsFloraison Tfloraison { get => tfloraison; set { OnPropertyChanged("TFloraison"); tfloraison = value; } }
        public int Exposition { get => exposition; set { OnPropertyChanged("Exposition"); exposition = value; } }
        public int TypeTerre { get => typeTerre; set { OnPropertyChanged("TypeTerre"); typeTerre = value; } }
    }
}
