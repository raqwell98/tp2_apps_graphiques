using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affaire
{
    public class Dimension 
    {
        private int x;
        private int y;

        public Dimension() { x = 0; y = 0; }
        public int X { get => x; set {  x = value;  } }
        public int Y { get => y; set {  y = value;  } }

        public override string ToString()
        {
            return x + " (cm) de long par "+ y + " (cm) de large";
        }


    }
}
