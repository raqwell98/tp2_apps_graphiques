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
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        // public Affaire.Connexion connexion;
        public Connexion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Affaire.Connexion con = ((Affaire.Connexion)this.DataContext);
            if (con.Connecte)
                con.Deconnecter();
            else
            {
                con.Connecter();
                this.idGrid.BindingGroup.CommitEdit();
                this.mpGrid.BindingGroup.CommitEdit();
                if (con.Connecte)
                {
                    ((MainWindow)System.Windows.Application.Current.MainWindow).Connexion = con;
                    this.Close();
                }
            }


        }
    }
}
