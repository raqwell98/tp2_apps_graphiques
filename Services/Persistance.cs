using Affaire;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Affaire;

namespace Services
{
    public class Persistance : INotifyPropertyChanged
    {
        //private ObservableCollection<Plante> plantes;
        private CollectionPlantesObservable plantes;
        private ScribeXML scribe;

        public CollectionPlantesObservable Plantes { get => plantes; set { plantes = value; sauvegarderDonnees(); OnPropertyChanged("Plantes"); } }

        public Persistance()
        {
            scribe = new ScribeXML();
            plantes = scribe.recupererPlantes();

        }
        public void initialiserDonnees()
        {
            scribe.inscrirePlantesInitiales();
            List<Plante> plantes = scribe.recupererPlantesInitiales();
            plantes.AddRange(this.plantes.ToList());
            Plantes = new CollectionPlantesObservable(plantes);
            File.Delete(@"annuelles.xml");
            File.Delete(@"legumes.xml");
        }

        public void sauvegarderDonnees()
        {
            plantes.trierParNoms();
            scribe.inscriresPlantes(plantes);
            plantes = scribe.recupererPlantes();
        }
       
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
