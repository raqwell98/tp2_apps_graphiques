﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Affaire
{
    [XmlInclude(typeof(Legume))]
    [XmlInclude(typeof(Vivace))]
    public class Plante : Produit
    {

        private TempsFloraison tfloraison;
        private Dimension dimension;
        private int exposition;


        public Plante() : base() { tfloraison = new TempsFloraison(); dimension = new Dimension(); exposition = 0; }
        public TempsFloraison Tfloraison { get => tfloraison; set {  tfloraison = value; OnPropertyChanged("DescriptionDetaillee"); } }
        public Dimension Dimension { get => dimension; set {  dimension = value; OnPropertyChanged("DescriptionDetaillee"); } }
        public int Exposition { get => exposition; set {  exposition = value; OnPropertyChanged("DescriptionDetaillee"); } }

        public override string DescriptionDetaillee
        {
            get
            {
                return base.DescriptionDetaillee + (Description == "" ? "" : "\n") +
                    tfloraison.ToString() +
                    "Dimension de " + dimension.ToString() + ". \n" +
                    "Exposition " + Constantes.Expositions[exposition] + ".";
            }
        }

    }
}
