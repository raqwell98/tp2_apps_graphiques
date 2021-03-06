﻿using System;
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
        private bool estVivace;

        public Legume() : base() { tempsRecolte = 0; type = 0; estVivace = false; Tfloraison.Debut = -1; }

        public int TempsRecolte { get => tempsRecolte; set {  tempsRecolte = value; OnPropertyChanged("DescriptionDetaillee"); } }
        public int Type { get => type; set {  type = value; OnPropertyChanged("DescriptionDetaillee"); } }
        public bool EstVivace { get => estVivace; set { estVivace = value; OnPropertyChanged("DescriptionDetaillee"); } }

        public override string DescriptionDetaillee
        {
            get
            {
                return base.DescriptionDetaillee + "\nÀ récolter en " + Constantes.Mois[tempsRecolte] + ". \n" +
                    "Plante d'" + Constantes.Saisons[type] + "." +
                    (estVivace ? "\nEst une vivace." : "");
            }
        }
    }
}
