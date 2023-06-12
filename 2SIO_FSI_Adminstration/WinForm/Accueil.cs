using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.WinForm;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration
{
    public partial class Accueil : Form
    {
        Utilisateur utilisateur;
        Database database = new Database();

        public Accueil(Utilisateur utilisateur1)
        {
            InitializeComponent();
            utilisateur = utilisateur1;
            tbUser.Text = utilisateur1.LoginUtilisateur;

            // database.createProfesseur();
            // database.addProfs();

            var message = string.Join(Environment.NewLine, database.getAllProfesseurs());
            MessageBox.Show(message);

            var message2 = string.Join(Environment.NewLine, database.getLogs());
            MessageBox.Show(message2);

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

        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new AjoutCour(utilisateur);
            newForm.Show();
        }

        private void supprimerUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new SupprCour(utilisateur);
            newForm.Show();
        }

        private void listeDesCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ListeCour(utilisateur);
            newForm.Show();
        }

        private void modifierUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ModifierClasse(utilisateur);
            newForm.Show();

        }

        private void modifierUnÉtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ModifierEtudiant(utilisateur);
            newForm.Show();

        }

        private void modifierUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ModifierCours(utilisateur);
            newForm.Show();
        }

        private void supprimerUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new SuprrClasse(utilisateur);
            newForm.Show();
        }
    }
}
