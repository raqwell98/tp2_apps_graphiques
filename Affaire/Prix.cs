﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Prix : INotifyPropertyChanged
    {
        private float prixVente;
        private float prixUnitaire;

        public Prix() { PrixVente = 0; prixUnitaire = 0; }

        public float PrixVente { get => prixVente; set {  prixVente = value; OnPropertyChanged("PrixVente"); } }
        public float PrixUnitaire { get => prixUnitaire; set {  prixUnitaire = value; OnPropertyChanged("PrixUnitaire"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string nomPropriete)

        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(nomPropriete));
            }
        }
    }
}
