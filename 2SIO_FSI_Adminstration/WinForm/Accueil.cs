using _2SIO_FSI_Adminstration.Classe;
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
            Form newForm = new Connexion();
            newForm.Show();
        }

        /// Début du code des ToolStripMenu.
        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ListeEtudiant(utilisateur);
            newForm.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new AjoutEtudiant(utilisateur);
            newForm.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ListeClasse(utilisateur);
            newForm.Show();
        }

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new AjoutClasse(utilisateur);
            newForm.Show();
        }

        private void supprimerUnÉtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new SupprEtudiant(utilisateur);
            newForm.Show();
        }
    }
}
