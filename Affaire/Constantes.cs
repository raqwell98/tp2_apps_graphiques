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
        public static class TypeTaille
        {
            public static readonly string[] Noms = {"3/4 pousse de l'années", "1/2 pousse de l'années", "Au sol" };
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
