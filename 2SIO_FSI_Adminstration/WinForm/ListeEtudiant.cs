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
            foreach (Etudiant etu in database.getAllEtudiants())
            {
                dgvEtudiants.Rows.Add(etu.NomEtudiant, etu.PrenomEtudiant, etu.IdClasse);
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

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeEtudiant(utilisateur);
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjouterEtudiant = new AjoutEtudiant(utilisateur);
            formAjouterEtudiant.Show();
        }

        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form formAccueil = new Accueil(utilisateur);
            formAccueil.Show();
        }

        private void dgvEtudiants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
