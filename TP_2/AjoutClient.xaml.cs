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
    /// Logique d'interaction pour AjoutClient.xaml
    /// </summary>
    public partial class AjoutClient : Window
    {
        public AjoutClient()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            if (champsCorrects())
            {
                MainWindow main = ((MainWindow)System.Windows.Application.Current.MainWindow);
                main.Persistance.Clients.Add((Client)this.DataContext);
                main.Persistance.sauvegarderDonnees();
                this.Close();
            }
            else
                this.torcerValidation();
        }
        private bool champsCorrects()
        {
            bool champsRemplis = tbNom.Text != "" && tbPrenom.Text != "" && tbID.Text != "" &&
                 tbNumTel.Text != "" && tbCourriel.Text != "" && tbCodePostal.Text != "";
            return champsRemplis && !(Validation.GetHasError(tbNom) || Validation.GetHasError(tbPrenom) ||
                                          Validation.GetHasError(tbNumTel) || Validation.GetHasError(tbID) ||
                                          Validation.GetHasError(tbCourriel) || Validation.GetHasError(tbCodePostal));
        }
        private void torcerValidation()
        {
            tbNom.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbPrenom.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbID.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbNumTel.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbCourriel.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbCodePostal.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }
    }
}
