using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class TempsFloraison 
    {
        private int debut;
        private int fin;
        public TempsFloraison() { debut = 0; fin = 0; }
        public int Fin { get => fin; set {  fin = value; } }
        public int Debut { get => debut; set { debut = value; } }

        public override string ToString()
        {
            return (debut == -1) ? "" : Constantes.Mois[debut] + " à " + Constantes.Mois[fin] + ". \n";
        }


    }
}
