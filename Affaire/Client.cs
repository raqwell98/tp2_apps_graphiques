using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Client : INotifyPropertyChanged
    {
        private string nom;
        private string prenom;
        private string id;
        private string numTel;
        private string courriel;
        private string province;

        public Client() { nom = ""; prenom = ""; id = ""; numTel = ""; courriel = ""; province = ""; }
        public string Nom { get => nom; set { nom = value; OnPropertyChanged("Nom"); } }
        public string Prenom { get => prenom; set { prenom = value; OnPropertyChanged("Prenom"); }
}
        public string Id { get => id; set { id = value; OnPropertyChanged("Id"); } }
        public string NumTel { get => numTel; set { numTel = value; OnPropertyChanged("NumTel"); } }
        public string Courriel { get => courriel; set { courriel = value; OnPropertyChanged("Courriel"); } }
        public string Province { get => province; set { province = value; OnPropertyChanged("Province"); } }

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
