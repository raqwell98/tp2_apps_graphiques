using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class CollectionClientsObservable : ObservableCollection<Client>
    {
        public CollectionClientsObservable() : base() { }
        public CollectionClientsObservable(List<Client> liste) : base(liste) { }

        public void trierParNoms()
        {
            List<Client> clientsOrdonnes = this.ToList();
            clientsOrdonnes.Sort((x,y) => x.Nom.CompareTo(y.Nom));
            this.Clear();
            this.Add(clientsOrdonnes);
        }
        public void trierParProvinces()
        {
            List<Client> clientsOrdonnes = this.ToList();
            clientsOrdonnes.Sort((x,y) => x.Province.CompareTo(y.Province));
            this.Clear();
            this.Add(clientsOrdonnes);
        }
        public void trierParId()
        {
            List<Client> clientsOrdonnes = this.ToList();
            clientsOrdonnes.Sort((x,y) => Convert.ToInt32(x.Id).CompareTo(Convert.ToInt32(y.Id)));
            this.Clear();
            this.Add(clientsOrdonnes);
        }
        public void Add(List<Client> clients)
        {
            foreach (Client c in clients)
                this.Add(c);
        }

    }
}
