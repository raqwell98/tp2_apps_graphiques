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

        public void Connecter() { Connecte = Constantes.Utilisateur.estValide(Utilisateur.Identifiant) && Constantes.MotDePasse.estValide(MotDePasse); avertir(); }
        public void Deconnecter() { Connecte = false; Utilisateur = new Utilisateur(); MotDePasse = ""; avertir(); }

        public void avertir()
        {
            OnPropertyChanged("PeuxConsulter");
            OnPropertyChanged("PeuxModifier");
            OnPropertyChanged("PeuxTout");
            OnPropertyChanged("Connecte");
            OnPropertyChanged("MotDePasse");
            OnPropertyChanged("Utilisateur");
        }

        public bool PeuxConsulter { get => connecte && (motDePasse == Constantes.MotDePasse.Consultation || PeuxModifier); }
        public bool PeuxModifier { get => connecte && (motDePasse == Constantes.MotDePasse.Modification || PeuxTout);}
        public bool PeuxTout { get => connecte && (motDePasse == Constantes.MotDePasse.Super); }

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
