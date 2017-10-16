using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Vivace : Plante
    {
        private int zone;
        private bool estArbre;
        private bool estArbuste;
        public Vivace() : base(){ zone = 0; estArbre = false; estArbuste = false;  }
        public int Zone { get => zone; set {  zone = value; OnPropertyChanged("Zone"); } }

        public bool EstArbre { get => estArbre; set { estArbre = value; OnPropertyChanged("EstArbre"); } }
        public bool EstArbuste { get => estArbuste; set { estArbuste = value; OnPropertyChanged("EstArbuste"); } }

        public override string Caracteristiques
        {
            get
            {
                return base.Caracteristiques + "\nPlante zonée " + Constantes.Zones[zone] + ". \n" +
                     "Est une vivace." + (estArbre ? "\nEst un arbre" : estArbuste? "\nEst un arbuste." : "");
            }
            set => base.Caracteristiques = value;
        }
    }
}
