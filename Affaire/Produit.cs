using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public abstract class Produit : INotifyPropertyChanged
    {
        private string nom;
        private Dimension dimension;
        private Prix prix;
        private int quantite;
        

        public Produit() { nom = ""; dimension = new Dimension(); prix = new Prix(); quantite = 0; }

        public string Nom { get => nom; set { OnPropertyChanged("Nom"); nom = value; } }
        public Dimension Dimension { get => dimension; set { OnPropertyChanged("Dimension"); dimension = value; } }
        public Prix Prix { get => prix; set { OnPropertyChanged("Prix"); prix = value; } }
        public int Quantite { get => quantite; set { OnPropertyChanged("Quantite"); quantite = value; } }
        

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
