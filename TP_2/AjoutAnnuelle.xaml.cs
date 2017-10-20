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
        public AjoutAnnuelle()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            if (champsCorrects())
            {
                MainWindow main = ((MainWindow)System.Windows.Application.Current.MainWindow);
                main.Persistance.Plantes.Add((Plante)this.DataContext);
                main.Persistance.sauvegarderDonnees();
                this.Close();
            }
            else
                this.forcerValidation();
        }
        private bool champsCorrects()
        {
            bool champsRemplis = tbNom.Text != "" && tbIdentifiant.Text != "";
            return champsRemplis && !(Validation.GetHasError(tbNom) || Validation.GetHasError(tbIdentifiant) ||
                                          Validation.GetHasError(tbQuantite) || Validation.GetHasError(tbDescription));
        }
        private void forcerValidation()
        {
            tbNom.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbIdentifiant.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbQuantite.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbDescription.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }
    }
}
