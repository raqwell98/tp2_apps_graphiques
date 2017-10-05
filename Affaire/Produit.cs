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
        private string description;
        private string sku;
        private Prix prix;
        private int quantite;
        

        public Produit() { nom = ""; prix = new Prix(); quantite = 0; description = ""; sku = ""; }

        public string Nom { get => nom; set { OnPropertyChanged("Nom"); nom = value; } }
        public string Description { get => description; set { OnPropertyChanged("Description"); description = value; } }
        public string SKU { get => sku; set { OnPropertyChanged("SKU"); sku = value; } }
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
