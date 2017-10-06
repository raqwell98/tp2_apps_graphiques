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

        public Utilisateur() { identifiant = "";}
        public string Identifiant { get => identifiant; set => identifiant = value; }
    }
}
