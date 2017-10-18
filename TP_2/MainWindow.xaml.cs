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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Affaire;
using System.Data;
using Services;
using System.Collections.ObjectModel;

namespace TP_2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Affaire.Connexion connexion;
        private Persistance persistance;


        public Affaire.Connexion Connexion { get => connexion; set => connexion = value; }
        public Persistance Persistance { get => persistance; set => persistance = value; }

        public MainWindow()
        {
            InitializeComponent();
            connexion = new Affaire.Connexion();
            initialiserConnection();
            persistance = new Persistance();
            this.DataContext = connexion;
            lbConsultation.DataContext = persistance;
           // lbConsultation.ItemsSource = persistance.Plantes;

        }

        private void initialiserConnection()
        {
            Connexion con = new Connexion();
            con.DataContext = connexion;
            con.ShowDialog();
        }
        private void ajout_Click(object sender, RoutedEventArgs e)
        {
            string nomAppelant = ((MenuItem)sender).Header.ToString();
            Window fenetre = 
                nomAppelant == "Annuelle" ? (Window)new AjoutAnnuelle() :
                nomAppelant == "Legume" ? (Window)new AjoutLegume() :
                (Window)new AjoutVivace();

            fenetre.Title = "Formulaire " + nomAppelant;
            fenetre.Show();
        }
        private void peupler_Click(object sender, RoutedEventArgs e)
        {
                persistance.initialiserDonnees();
        }

        private void trier_Click(object sender, RoutedEventArgs e)
        {
            if (((MenuItem)sender).Header.ToString() == "SKUs")
                persistance.Plantes.trierParSKU();
            else
                persistance.Plantes.trierParNoms();
            // Cool code linq qui mérite d'être conservé List<string> nomsPlante = persistance.Plantes.Select(x => x.Nom).ToList();
        }

        private void deconnecter_Click(object sender, RoutedEventArgs e)
        {
            initialiserConnection();
        }

        private void ajoutClient_Click(object sender, RoutedEventArgs e)
        {
            new AjoutClient().Show();
        }

        private void consultation_Click(object sender, RoutedEventArgs e)
        {
            string consultation = ((MenuItem)sender).Header.ToString();
            if(consultation == "consultationClient")
            {

            }
        }
    }
}
