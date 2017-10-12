using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Affaire
{
    public class CollectionPlantesObservable : ObservableCollection<Plante>
    {
        public CollectionPlantesObservable() : base() { }
        public CollectionPlantesObservable (List<Plante> liste) : base(liste) { }

        public void trierParNoms()
        {
            List<Plante> plantesOrdonnes = this.ToList();
            plantesOrdonnes.Sort((Plante x, Plante y) => x.Nom.CompareTo(y.Nom));
            this.Clear();
            foreach (Plante p in plantesOrdonnes)
                this.Add(p);

        }
        public void trierParSKU()
        {
            List<Plante> plantesOrdonnes = this.ToList();
            plantesOrdonnes.Sort((Plante x, Plante y) => x.SKU.CompareTo(y.SKU));
            this.Clear();
            foreach (Plante p in plantesOrdonnes)
                this.Add(p);

        }

    }
}
