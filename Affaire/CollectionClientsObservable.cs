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
            clientsOrdonnes.Sort((Client x, Client y) => x.Nom.CompareTo(y.Nom));
            this.Clear();
            foreach (Client p in clientsOrdonnes)
                this.Add(p);

        }
        public void trierParProvinces()
        {
            List<Client> clientsOrdonnes = this.ToList();
            clientsOrdonnes.Sort((Client x, Client y) => x.Province.CompareTo(y.Province));
            this.Clear();
            foreach (Client p in clientsOrdonnes)
                this.Add(p);

        }
        public void trierParId()
        {
            List<Client> clientsOrdonnes = this.ToList();
            clientsOrdonnes.Sort((Client x, Client y) => x.Id.CompareTo(y.Id));
            this.Clear();
            foreach (Client p in clientsOrdonnes)
                this.Add(p);

        }

    }
}
