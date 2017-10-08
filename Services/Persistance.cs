using Affaire;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Persistance : INotifyPropertyChanged
    {
        private ObservableCollection<Plante> plantes;
        private ScribeXML scribe;

        public Persistance()
        {
            scribe = new ScribeXML();
            plantes = scribe.recupererPlantes();
        }

        public void initialiserDonnees()
        {
            scribe.inscrirePlantesInitiales();
            List<Plante> l = scribe.recupererPlantesInitiales();
            l.AddRange(plantes.ToList<Plante>());
            Plantes = new ObservableCollection<Plante>(l);
            File.Delete(@"annuelles.xml");
            File.Delete(@"legumes.xml");
        }

        public void sauvegarderDonnees()
        {
            scribe.inscriresPlantes(plantes);
        }
        public ObservableCollection<Plante> Plantes { get => plantes; set { plantes = value; OnPropertyChanged("Plantes"); } }

        
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
