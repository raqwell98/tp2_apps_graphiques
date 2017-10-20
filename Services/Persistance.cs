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
    public class Persistance 
    {
        private CollectionClientsObservable clients;
        private CollectionPlantesObservable plantes;
        private ScribeXML scribe;

        public CollectionPlantesObservable Plantes { get => plantes; set => plantes = value; }

        public CollectionClientsObservable Clients { get => clients; set => clients = value; }

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
            clients.Add(scribe.recupererClientsInitiales());
            plantes.Add(scribe.recupererPlantesInitiales());
            sauvegarderDonnees();

        }

        public void sauvegarderDonnees()
        {
            plantes.trierParNoms();
            clients.trierParNoms();
            scribe.inscriresClients(clients);
            scribe.inscriresPlantes(plantes);
        }
       
    }
}
