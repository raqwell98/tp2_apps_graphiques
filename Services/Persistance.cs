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
        private CollectionClientsObservable clients;
        private CollectionPlantesObservable plantes;
        private ScribeXML scribe;

        public CollectionPlantesObservable Plantes { get => plantes; set { plantes = value; sauvegarderDonnees(); OnPropertyChanged("Plantes"); } }

        public CollectionClientsObservable Clients { get => clients; set { clients = value; sauvegarderDonnees();  OnPropertyChanged("Clients"); }
}

        public Persistance()
        {
            scribe = new ScribeXML();
            clients = scribe.recupererClients();
            plantes = scribe.recupererPlantes();

        }
        public void initialiserDonnees()
        {
            scribe.inscrirePlantesInitiales();
            scribe.inscrireClientsInitiales();
            List<Client> clients = scribe.recupererClientsInitiales();
            List<Plante> plantes = scribe.recupererPlantesInitiales();
            clients.AddRange(this.clients.ToList());
            plantes.AddRange(this.plantes.ToList());
            Clients = new CollectionClientsObservable(clients);
            Plantes = new CollectionPlantesObservable(plantes);
            File.Delete(@"annuelles.xml");
            File.Delete(@"legumes.xml");
        }

        public void sauvegarderDonnees()
        {
            plantes.trierParNoms();
            clients.trierParNoms();
            scribe.inscriresClients(clients);
            scribe.inscriresPlantes(plantes);
            plantes = scribe.recupererPlantes();
            clients = scribe.recupererClients();
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
