using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Connexion
    {
        private string motDePasse;
        private Utilisateur utilisateur;

        public Connexion(Utilisateur u, string mp) { utilisateur = u; motDePasse = mp; }

        public bool peuxConsulter() => motDePasse == Constantes.MotDePasse.Modification || peuxModifier() || peuxTout();
        public bool peuxModifier() => motDePasse == Constantes.MotDePasse.Consultation || peuxTout();
        public bool peuxTout() => motDePasse == Constantes.MotDePasse.Super;

        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public Utilisateur Utilisateur { get => utilisateur; set => utilisateur = value; }
    }
}
