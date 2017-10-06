using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Dimension : INotifyPropertyChanged
    {
        private float z;
        private float x;
        private float y;

        public Dimension() { z = 0; x = 0; y = 0; }
        public float Z { get => z; set { z = value; OnPropertyChanged("Z"); } }
        public float X { get => x; set {  x = value; OnPropertyChanged("X"); } }
        public float Y { get => y; set {  y = value; OnPropertyChanged("Y"); } }

        public override string ToString()
        {
            return (x == 0 ? "" : x + " cm W / ") +
                     (y == 0 ? "" : y + " cm L / ") +
                       (z == 0 ? "" : z + " cm H.");
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
