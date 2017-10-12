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
        public static class MotDePasse
        {
            public static string Consultation = "mp1";
            public static string Modification = "mp2";
            public static string Super = "mp3";

            public static bool estValide(string mp) => mp == Consultation || mp == Modification || mp == Super;
        }

        public static class Utilisateur
        {
            public static string Consultation = "utilisateur1";
            public static string Modification = "utilisateur2";
            public static string Super = "utilisateur3";

            public static bool estValide(string n) => n == Consultation || n == Modification || n == Super;
        }
        public static class Exposition
        {
            public static readonly string[] Noms = { "Soleil", "Ombre", "Mi-Ombre" };
        }
        public static class Zone
        {
            public static readonly string[] Noms = {"Zone 1", "Zone 2", "Zone 3", "Zone 4", "Zone 5" };
        }
        public static class TypeTerre
        {
            public static readonly string[] Noms = {"HR","Acide","Alcaline","Mousse de tourbe"};
        }
        public static class Saison
        {
            public static readonly string[] Noms = { "Printemps", "Été", "Automne", "Hiver" };
        }
        public static class Mois
        {
            public static readonly string[] Noms = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
        }
    }
}
