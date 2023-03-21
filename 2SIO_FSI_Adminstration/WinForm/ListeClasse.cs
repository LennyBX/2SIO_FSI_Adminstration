using _2SIO_FSI_Adminstration.Classe;
using System;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeClasse : Form
    {
        Database database = new Database();
        Utilisateur utilisateur;

        public ListeClasse(Utilisateur utilisateur1)
        {
            InitializeComponent();
            utilisateur = utilisateur1;
            foreach (Classe.Classe classe in database.getAllClasses())
            {
                dgvEtudiants.Rows.Add(classe.LibelleClasse);
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
        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAccueil = new Accueil(utilisateur);
            formAccueil.Show();
        }

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

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAjoutClasse = new AjoutClasse(utilisateur);
            formAjoutClasse.Show();
        }
    }
}
