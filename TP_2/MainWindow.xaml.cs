﻿using System;
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

namespace TP_2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Affaire.Connexion connexion;

        public Affaire.Connexion Connexion { get => connexion; set => connexion = value; }

        public MainWindow()
        {
            InitializeComponent();
            initialiserConnection();
        }
        private void initialiserConnection()
        {
            new Connexion().ShowDialog();
        }
        private void annuelle_Click(object sender, RoutedEventArgs e)
        {
            AjoutAnnuelle ajout = new AjoutAnnuelle();
            ajout.DataContext = new FleurAnnuelle();
            ajout.ShowDialog();
        }

        private void vivace_Click(object sender, RoutedEventArgs e)
        {
            AjoutVivace ajout = new AjoutVivace();
            ajout.ShowDialog();
        }

        private void legume_Click(object sender, RoutedEventArgs e)
        {
            AjoutLegume ajout = new AjoutLegume();
            ajout.ShowDialog();
        }

        private void arbre_Click(object sender, RoutedEventArgs e)
        {
            AjoutArbreArbuste ajout = new AjoutArbreArbuste();
            ajout.ShowDialog();
        }

        
    }
}
