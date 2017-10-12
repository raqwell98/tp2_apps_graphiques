using Affaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TP_2
{
    /// <summary>
    /// Logique d'interaction pour AjoutAnnuelle.xaml
    /// </summary>
    public partial class AjoutAnnuelle : Window
    {
        private FleurAnnuelle fleurAnnuelle;
        public AjoutAnnuelle()
        {
            InitializeComponent();
            //fleurAnnuelle = new FleurAnnuelle();
            //this.DataContext = fleurAnnuelle as FleurAnnuelle;
        }
    }
}
