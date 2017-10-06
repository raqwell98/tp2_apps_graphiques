using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Connexion : INotifyPropertyChanged
    {
        private string motDePasse;
        private Utilisateur utilisateur;

        public Connexion() { utilisateur = new Utilisateur(); motDePasse = ""; }

        public bool peuxConsulter() => motDePasse == Constantes.MotDePasse.Modification || peuxModifier();
        public bool peuxModifier() => motDePasse == Constantes.MotDePasse.Consultation || peuxTout();
        public bool peuxTout() => motDePasse == Constantes.MotDePasse.Super;

        public string MotDePasse { get => motDePasse; set { OnPropertyChanged("Utilisateur"); motDePasse = value; } }
        public Utilisateur Utilisateur { get => utilisateur; set { OnPropertyChanged("Utilisateur");  utilisateur = value; } }

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
