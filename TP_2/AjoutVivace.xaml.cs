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
using Affaire;

namespace TP_2
{
    /// <summary>
    /// Logique d'interaction pour AjoutVivace.xaml
    /// </summary>
    public partial class AjoutVivace : Window
    {
        public AjoutVivace()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            if(champsCorrects())
            {
                MainWindow main = ((MainWindow)System.Windows.Application.Current.MainWindow);
                main.Persistance.Plantes.Add((Plante)this.DataContext);
                main.Persistance.sauvegarderDonnees();
                this.Close();
            }
        }
        private bool champsCorrects()
        {
            bool champsRemplis = tbNom.Text != "" && tbIdentifiant.Text != "" && tbQuantite.Text != "" &&
                 tbDescription.Text != "";
            return champsRemplis && !(Validation.GetHasError(tbNom) || Validation.GetHasError(tbIdentifiant) ||
                                          Validation.GetHasError(tbQuantite) || Validation.GetHasError(tbDescription));
        }
    }
}
