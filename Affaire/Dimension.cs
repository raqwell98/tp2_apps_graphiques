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
        private float x;
        private float y;

        public Dimension() { x = 0; y = 0; }
        public float X { get => x; set {  x = value; } }
        public float Y { get => y; set { y = value; } }

        public override string ToString()
        {
            return (x == 0 ? "" : x + " cm de haut / ") +
                     (y == 0 ? "" : y + " cm de large");
        }
    }
}
