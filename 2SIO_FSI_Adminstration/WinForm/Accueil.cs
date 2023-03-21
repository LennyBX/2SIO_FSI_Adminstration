﻿using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.WinForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration
{
    public partial class Accueil : Form
    {
        Utilisateur utilisateur;

        public Accueil(Utilisateur utilisateur1)
        {
            InitializeComponent();
            utilisateur = utilisateur1;
            tbUser.Text = utilisateur1.LoginUtilisateur;
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Form connectionForm = new Connexion();
            connectionForm.Show();
        }

        /// Début du code des ToolStripMenu.
        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formListeEtudiant = new ListeEtudiant(utilisateur);
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAjouterEtudiant = new AjoutEtudiant(utilisateur);
            formAjouterEtudiant.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formListeClasse = new ListeClasse(utilisateur);
            formListeClasse.Show();
        }

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAjoutClasse = new AjoutClasse(utilisateur);
            formAjoutClasse.Show();
        }
    }
}
