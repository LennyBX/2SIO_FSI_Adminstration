using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeEtudiant : Form
    {
        Database database = new Database();
        Utilisateur utilisateur;

        public ListeEtudiant(Utilisateur utilisateur1)
        {
            InitializeComponent();
            utilisateur = utilisateur1;
            List<Etudiant> etudiants = database.getAllEtudiants();
            foreach (Etudiant etu in etudiants)
            {
                dgvEtudiants.Rows.Add(etu.NomEtudiant, etu.PrenomEtudiant, etu.ClasseEtudiant.AcronymeClasse);
            }
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAccueil = new Accueil(utilisateur);
            formAccueil.Show();
        }

        /// Début du code des ToolStripMenu.
        private void listeDesEtudiantsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ListeEtudiant(utilisateur);
            newForm.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new AjoutEtudiant(utilisateur);
            newForm.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ListeClasse(utilisateur);
            newForm.Show();
        }

        private void ajouterUneClasseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new AjoutClasse(utilisateur);
            newForm.Show();
        }

        private void supprimerUnÉtudiantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new SupprEtudiant(utilisateur);
            newForm.Show();
        }

        private void ajouterUnCoursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new AjoutCour(utilisateur);
            newForm.Show();
        }

        private void supprimerUnCoursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new SupprCour(utilisateur);
            newForm.Show();
        }

        private void listeDesCoursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ListeCour(utilisateur);
            newForm.Show();
        }

        private void modifierUneClasseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ModifierClasse(utilisateur);
            newForm.Show();

        }

        private void modifierUnÉtudiantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ModifierEtudiant(utilisateur);
            newForm.Show();

        }

        private void modifierUnCoursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new ModifierCours(utilisateur);
            newForm.Show();
        }

        private void supprimerUneClasseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new SuprrClasse(utilisateur);
            newForm.Show();
        }

    }
}
