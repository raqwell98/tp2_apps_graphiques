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
        private bool connecte;

        public Connexion() { utilisateur = new Utilisateur(); motDePasse = ""; connecte = false; }

        public void Connecter() { Connecte = Constantes.Utilisateur.estValide(Utilisateur.Identifiant) && Constantes.MotDePasse.estValide(MotDePasse); }
        public void Deconnecter() { Connecte = false; Utilisateur = new Utilisateur(); MotDePasse = ""; }
        public bool peuxConsulter() => connecte && (motDePasse == Constantes.MotDePasse.Modification || peuxModifier());
        public bool peuxModifier() => connecte && (motDePasse == Constantes.MotDePasse.Consultation || peuxTout());
        public bool peuxTout() => connecte && (motDePasse == Constantes.MotDePasse.Super);

        public bool Connecte { get => connecte; set { connecte = value; OnPropertyChanged("Connecte"); } }
        public string MotDePasse { get => motDePasse; set { motDePasse = value; OnPropertyChanged("MotDePasse"); } }
        public Utilisateur Utilisateur { get => utilisateur; set { utilisateur = value; OnPropertyChanged("Utilisateur"); } }

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
