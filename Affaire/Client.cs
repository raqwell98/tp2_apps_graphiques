using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Client
    {
        private string nom;
        private string prenom;
        private string id;
        private string numTel;
        private string courriel;
        private string province;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Id { get => id; set => id = value; }
        public string NumTel { get => numTel; set => numTel = value; }
        public string Courriel { get => courriel; set => courriel = value; }
        public string Province { get => province; set => province = value; }
    }
}
