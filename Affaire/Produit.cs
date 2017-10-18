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
        private int quantite;
        private Prix prix;
        private string format;


        public Produit() { nom = ""; prix = new Prix(); quantite = 0; description = ""; sku = ""; format = ""; }
        public string Nom { get => nom; set {  nom = value; OnPropertyChanged("Nom"); } }
        public string Description { get => description; set => description = value; }
        public virtual string DescriptionDetaillee { get => description; }
        public string SKU { get => sku; set {  sku = value; OnPropertyChanged("SKU"); } }
        public Prix Prix { get => prix; set {  prix = value; OnPropertyChanged("Prix"); } }
        public int Quantite { get => quantite; set { quantite = value; OnPropertyChanged("Quantite"); } }
        public string Format { get => format; set { format = value; OnPropertyChanged("DescriptionDetaillee"); } }


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
