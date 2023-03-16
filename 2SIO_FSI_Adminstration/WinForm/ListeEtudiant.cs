﻿using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeEtudiant : Form
    {
        Utilisateur x;
        public ListeEtudiant(Utilisateur utiConnecte)
        {
            InitializeComponent();
            x = utiConnecte;
            Form formAccueil = new Accueil(x);
            formAccueil.Close();



            //Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=FSI_Gestion;User Id=postgres;Password=pgadmin;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT * FROM etudiant";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            List<Etudiant> mesEtudiant = new List<Etudiant>();
            while (dr.Read())
            {
                // Création de l'objet etudiant
                int idEtudiant = dr.GetInt32(0);
                string nomEtudiant = dr.GetString(1);
                string prenomEtudiant = dr.GetString(2);

                Etudiant unEtudiant = new Etudiant(idEtudiant, nomEtudiant, prenomEtudiant);
                mesEtudiant.Add(unEtudiant);

            }

            //Affichage dans le dataGridView
            foreach (Etudiant etu in mesEtudiant)
            {
                dgvEtudiants.Rows.Add(etu.NomEtudiant, etu.PrenomEtudiant);

            }


            MyCnx.Close();

        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeEtudiant(x);
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjouterEtudiant = new AjoutEtudiant();
            formAjouterEtudiant.Show();
        }

        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form formAccueil = new Accueil(x);
            formAccueil.Show();
        }
    }
}
