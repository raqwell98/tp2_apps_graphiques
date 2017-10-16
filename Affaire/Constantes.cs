using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public static class Constantes
    {
        public static readonly string[] Mois = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
        public static readonly string[] Expositions = { "Soleil", "Ombre", "Mi-Ombre" };
        public static readonly string[] Zones = { "Zone 1", "Zone 2", "Zone 3", "Zone 4", "Zone 5" };
        public static readonly string[] Saisons = {"Été", "Hiver" };
        public static readonly string[] Provinces = { "Alberta", "Colombie-Britannique", "Manitoba", "Nouveau-Brunswick", "Terre-Neuve et Labrador", "Nouvelle-Écosse", "Ontario", "Île-du-Prince-Édouard", "Québec", "Saskatchewan" };
        public static class MotDePasse
        {
            public static string Consultation = "mp3";
            public static string Modification = "mp2";
            public static string Super = "mp1";

            public static bool estValide(string mp) => mp == Consultation || mp == Modification || mp == Super;
        }

        public static class Utilisateur
        {
            public static string Consultation = "utilisateur3";
            public static string Modification = "utilisateur2";
            public static string Super = "utilisateur1";

            public static bool estValide(string n) => n == Consultation || n == Modification || n == Super;
        }


    }
}
