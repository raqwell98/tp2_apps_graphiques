using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Utilisateur
    {
        private string identifiant;
        private string motDePasse;

        public Utilisateur() { identifiant = ""; motDePasse = ""; }
        public string Identifiant { get => identifiant; set => identifiant = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
    }
}
