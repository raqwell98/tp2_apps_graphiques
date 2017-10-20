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
        public int Zone { get => zone; set {  zone = value; OnPropertyChanged("DescriptionDetaillee"); } }
        public bool EstArbre { get => estArbre; set { estArbre = value; OnPropertyChanged("DescriptionDetaillee"); } }
        public bool EstArbuste { get => estArbuste; set { estArbuste = value; OnPropertyChanged("DescriptionDetaillee"); } }

        public override string DescriptionDetaillee
        {
            get
            {
                return base.DescriptionDetaillee + "\nPlante zonée " + Constantes.Zones[zone] + ". \n" +
                     "Est une vivace." + (estArbre ? "\nEst un arbre" : estArbuste? "\nEst un arbuste." : "");
            }
        }
    }
}
