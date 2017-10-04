using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class TempsFloraison : INotifyPropertyChanged
    {
        private int debut;
        private int fin;
        public TempsFloraison() { debut = 0; fin = 0; }

        public int Fin { get => fin; set { OnPropertyChanged("Fin"); fin = value; } }
        public int Debut { get => debut; set { OnPropertyChanged("Debut"); debut = value; } }

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
