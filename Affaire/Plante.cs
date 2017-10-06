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
        private Dimension dimension;
        private int exposition;
        private int typeTerre;

        public Plante() : base() { tfloraison = new TempsFloraison(); dimension = new Dimension(); exposition = 0; typeTerre = 0; }

        public TempsFloraison Tfloraison { get => tfloraison; set {  tfloraison = value; OnPropertyChanged("TFloraison"); } }
        public Dimension Dimension { get => dimension; set {  dimension = value; OnPropertyChanged("Dimension"); } }
        public int Exposition { get => exposition; set {  exposition = value; OnPropertyChanged("Exposition"); } }
        public int TypeTerre { get => typeTerre; set {  typeTerre = value; OnPropertyChanged("TypeTerre"); } }
    }
}
