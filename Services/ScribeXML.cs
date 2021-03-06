﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Affaire;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.IO;

namespace Services
{
    public class ScribeXML
    {   

        public ScribeXML() {}

        public void inscriresPlantes(CollectionPlantesObservable plantes)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(CollectionPlantesObservable));
            TextWriter Writer = new StreamWriter(@"plantes.xml");
            Serializer.Serialize(Writer, plantes);
            Writer.Close();
        }

        public void inscriresClients(CollectionClientsObservable clients)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(CollectionClientsObservable));
            TextWriter Writer = new StreamWriter(@"clients.xml");
            Serializer.Serialize(Writer, clients);
            Writer.Close();
        }


        public CollectionPlantesObservable recupererPlantes()
        {
            CollectionPlantesObservable plantes = new CollectionPlantesObservable();
            try
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(CollectionPlantesObservable));
                TextReader Reader = new StreamReader(@"plantes.xml");
                plantes = (CollectionPlantesObservable)Serializer.Deserialize(Reader);
                Reader.Close();

            }
            catch (Exception) {}
            return plantes;
        }

        public CollectionClientsObservable recupererClients()
        {
            CollectionClientsObservable clients = new CollectionClientsObservable();
            try
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(CollectionClientsObservable));
                TextReader Reader = new StreamReader(@"clients.xml");
                clients = (CollectionClientsObservable)Serializer.Deserialize(Reader);
                Reader.Close();

            }
            catch (Exception) { }
            return clients;
        }

        public void inscrireClientsInitiales()
        {
            DataTable dt;
            dt = new DataTable();
            dt.TableName = "Client";
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Prenom", typeof(string));
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("NumTel", typeof(string));
            dt.Columns.Add("Courriel", typeof(string));
            dt.Columns.Add("CodePostal", typeof(string));
            dt.Columns.Add("Province", typeof(string));


            DataRow dr = dt.NewRow();
            dr["Nom"] = "Bernard";
            dr["Prenom"] = "Adam";
            dr["Id"] = "1000";
            dr["NumTel"] = "418-228-5034";
            dr["Courriel"] = "adambernard@hotmail.com";
            dr["CodePostal"] = "g0a 1a2";
            dr["Province"] = "Québec";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Demers";
            dr["Prenom"] = "Charle";
            dr["Id"] = "1001";
            dr["NumTel"] = "418-332-5089";
            dr["Courriel"] = "demersCharle@hotmail.com";
            dr["CodePostal"] = "g0b 2b3";
            dr["Province"] = "Québec";
            dt.Rows.Add(dr);

            dt.AcceptChanges();

            dt.WriteXml(@"clients.xml", XmlWriteMode.WriteSchema);
        }
        public List<Client> recupererClientsInitiales()
        {
            List<Client> clientsInitiales = new List<Client>();
            DataTable dt = new DataTable();
            try
            {
                dt.ReadXml(@"clients.xml");
                foreach (DataRow row in dt.Rows)
                {
                    clientsInitiales.Add(new Client()
                    {
                        Nom = (string)row["Nom"],
                        Prenom = (string)row["Prenom"],
                        Id = (string)row["Id"],
                        Courriel = (string)row["Courriel"],
                        NumTel = (string)row["NumTel"],
                        Province = (string)row["Province"],
                        CodePostal = (string)row["CodePostal"]
                        
                    });
                }
            }
            catch (Exception) { }

            return clientsInitiales;
        }
        public void inscrirePlantesInitiales()
        {
            DataTable dt;
            dt = new DataTable();
            dt.TableName = "Annuelle";
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("SKU", typeof(string));
            dt.Columns.Add("PrixUnitaire", typeof(float));
            dt.Columns.Add("PrixVente", typeof(float));
            dt.Columns.Add("Format", typeof(string));
            dt.Columns.Add("TFDebut", typeof(int));
            dt.Columns.Add("TFFin", typeof(int));
            dt.Columns.Add("Quantite", typeof(int));
            dt.Columns.Add("DX", typeof(int));
            dt.Columns.Add("DY", typeof(int));
            dt.Columns.Add("Exposition", typeof(int));

            DataRow dr = dt.NewRow();
            dr["Nom"] = "Begonia";
            dr["Description"] = "";
            dr["SKU"] = "1000";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 4 pouces;";
            dr["PrixVente"] = 3.99f;
             dr["Exposition"] = 1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Calibrachoa";
            dr["Description"] = "";
            dr["SKU"] = "1001";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 3 pouces;";
            dr["PrixVente"] = 2.49f;
             dr["Exposition"] = 0;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Cleome";
            dr["Description"] = "";
            dr["SKU"] = "1002";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 3 pouces;";
            dr["PrixVente"] = 2.49f;
             dr["Exposition"] = 0;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Dahlia";
            dr["Description"] = "";
            dr["SKU"] = "1003";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 6 pouces;";
            dr["PrixVente"] = 6.49f;
             dr["Exposition"] = 0;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Geranium";
            dr["Description"] = "";
            dr["SKU"] = "1004";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 4 pouces;";
            dr["PrixVente"] = 3.99f;
             dr["Exposition"] = 0;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Impatiens";
            dr["Description"] = "";
            dr["SKU"] = "1005";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["PrixVente"] = 3.99f;
            dr["Format"] = "pot 4 pouces;";
             dr["Exposition"] = 1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Lobelia";
            dr["Description"] = "";
            dr["SKU"] = "1006";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 3 pouces;";
            dr["PrixVente"] = 2.49f;
             dr["Exposition"] = 0;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Marigold";
            dr["Description"] = "";
            dr["SKU"] = "1007";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 4 pouces;";
            dr["PrixVente"] = 3.99f;
             dr["Exposition"] = 0;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Petunia";
            dr["Description"] = "";
            dr["SKU"] = "1008";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 4 pouces;";
            dr["PrixVente"] = 3.99f;
             dr["Exposition"] = 0;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Nom"] = "Verveine";
            dr["Description"] = "";
            dr["SKU"] = "1009";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["Format"] = "pot 3 pouces;";
            dr["PrixVente"] = 2.49f;
             dr["Exposition"] = 0;
            dt.Rows.Add(dr);

            DataTable dt2;
            dt2 = new DataTable();
            dt2.TableName = "Legume";
            dt2.Columns.Add("Nom", typeof(string));
            dt2.Columns.Add("Description", typeof(string));
            dt2.Columns.Add("SKU", typeof(string));
            dt2.Columns.Add("PrixUnitaire", typeof(float));
            dt2.Columns.Add("PrixVente", typeof(float));
            dt2.Columns.Add("Format", typeof(string));
            dt2.Columns.Add("TFDebut", typeof(int));
            dt2.Columns.Add("TFFin", typeof(int));
            dt2.Columns.Add("Quantite", typeof(int));
            dt2.Columns.Add("DX", typeof(int));
            dt2.Columns.Add("DY", typeof(int));
            dt2.Columns.Add("Exposition", typeof(int));
            dt2.Columns.Add("EstVivace", typeof(bool));
            dt2.Columns.Add("Type", typeof(int));
            dt2.Columns.Add("TempsRecolte", typeof(int));


            dr = dt2.NewRow();
            dr["Nom"] = "Aubergine";
            dr["Description"] = "";
            dr["SKU"] = "2001";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pot 3,5 pouces;";
            dr["PrixVente"] = 2.69f;
             dr["Exposition"] = 0;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);

            dr = dt2.NewRow();
            dr["Nom"] = "Brocoli";
            dr["Description"] = "";
            dr["SKU"] = "2002";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pack de 9";
            dr["PrixVente"] = 4.39f;
             dr["Exposition"] = 0;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);

            dr = dt2.NewRow();
            dr["Nom"] = "Céleri";
            dr["Description"] = "";
            dr["SKU"] = "2003";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pack de 9";
            dr["PrixVente"] = 4.39f;
             dr["Exposition"] = 0;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);

            dr = dt2.NewRow();
            dr["Nom"] = "Concombre";
            dr["Description"] = "";
            dr["SKU"] = "2004";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pack de 4";
            dr["PrixVente"] = 2.89f;
             dr["Exposition"] = 0;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);

            dr = dt2.NewRow();
            dr["Nom"] = "Fève";
            dr["Description"] = "";
            dr["SKU"] = "2005";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pack de 4";
            dr["PrixVente"] = 2.89f;
             dr["Exposition"] = 0;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);

            dr = dt2.NewRow();
            dr["Nom"] = "Kale";
            dr["Description"] = "";
            dr["SKU"] = "2006";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
            dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pack de 6";
            dr["PrixVente"] = 3.49f;
            dr["Exposition"] = 1;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);

            dr = dt2.NewRow();
            dr["Nom"] = "Poivron";
            dr["Description"] = "";
            dr["SKU"] = "2007";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pack de 9";
            dr["PrixVente"] = 4.39f;
             dr["Exposition"] = 0;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);

            dr = dt2.NewRow();
            dr["Nom"] = "Tomate";
            dr["Description"] = "";
            dr["SKU"] = "2008";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pot 6 pouces;";
            dr["PrixVente"] = 5.99f;
             dr["Exposition"] = 0;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);

            dr = dt2.NewRow();
            dr["Nom"] = "Zucchini";
            dr["Description"] = "";
            dr["SKU"] = "2009";
            dr["PrixUnitaire"] = 1.99f;
            dr["TFDebut"] = 1;
            dr["TFFin"] = 1;
            dr["Quantite"] = 1;
            dr["DX"] = 25;
            dr["DY"] = 50;
             dr["Exposition"] = 0;
            dr["EstVivace"] = false;
            dr["Format"] = "pot 3,5 pouces;";
            dr["PrixVente"] = 2.69f;
             dr["Exposition"] = 0;
            dr["Type"] = 1;
            dr["TempsRecolte"] = 1;
            dt2.Rows.Add(dr);


            dt.AcceptChanges();
            dt2.AcceptChanges();

            dt.WriteXml(@"annuelles.xml", XmlWriteMode.WriteSchema);
            dt2.WriteXml(@"legumes.xml", XmlWriteMode.WriteSchema);
        }
        public List<Plante> recupererPlantesInitiales()
        {
            List<Plante> plantesInitiales = new List<Plante>();
            DataTable dt = new DataTable();
            try
            {
                dt.ReadXml(@"annuelles.xml");
                List<Plante> annuelles = new List<Plante>();
                foreach (DataRow row in dt.Rows)
                {
                    annuelles.Add(new Plante()
                    {
                        Nom = (string)row["Nom"],
                        Description = (string)row["Description"],
                        SKU = (string)row["SKU"],
                        Prix = new Prix() { PrixUnitaire = (float)row["PrixUnitaire"], PrixVente = (float)row["PrixUnitaire"] },
                        Format = (string)row["Format"],
                        Dimension = new Dimension() { Y = (int)row["DY"], X = (int)row["DX"] },
                        Quantite = (int)row["Quantite"],
                        Tfloraison = new TempsFloraison() { Debut = (int)row["TFDebut"], Fin = (int)row["TFFin"] },
                        Exposition = (int)row["Exposition"]
                    });
                }
                plantesInitiales.AddRange(annuelles);
            }
            catch (Exception) { }
            try
            {
                dt = new DataTable();
                dt.ReadXml(@"legumes.xml");
                List<Plante> legumes = new List<Plante>();
                foreach (DataRow row in dt.Rows)
                {
                    legumes.Add(new Legume()
                    {
                        Nom = (string)row["Nom"],
                        Description = (string)row["Description"],
                        SKU = (string)row["SKU"],
                        Prix = new Prix() { PrixUnitaire = (float)row["PrixUnitaire"], PrixVente = (float)row["PrixUnitaire"] },
                        Format = (string)row["Format"],
                        Dimension = new Dimension() { Y = (int)row["DY"], X = (int)row["DX"] },
                        Quantite = (int)row["Quantite"],
                        Tfloraison = new TempsFloraison() { Debut = (int)row["TFDebut"], Fin = (int)row["TFFin"] },
                        Exposition = 1,
                        Type = (int)row["Type"],
                        TempsRecolte = (int)row["TempsRecolte"],
                        EstVivace = (bool)row["EstVivace"]

                    });
                }
                plantesInitiales.AddRange(legumes);
            }
            catch (Exception) { }
            File.Delete(@"annuelles.xml");
            File.Delete(@"legumes.xml");
            return plantesInitiales;
        }
    }
}
