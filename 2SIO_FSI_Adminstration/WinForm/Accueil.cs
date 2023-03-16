using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.WinForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration
{
    public partial class Accueil : Form
    {
        Utilisateur uti;
        public Accueil(Utilisateur utiConnecte)
        {

            InitializeComponent();
            uti = utiConnecte;
            Form formConnexion = new Connexion();
            formConnexion.Close();
            tbUserConnecte2.Text = uti.LoginUtilisateur;

            Database database = new Database();
            List<Utilisateur> utilisateurs = database.getAllUtilisateurs();
            foreach(Utilisateur value in utilisateurs)
            {
                Console.WriteLine(value.LoginUtilisateur);
            }

        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeEtudiant(uti);
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjouterEtudiant = new AjoutEtudiant();
            formAjouterEtudiant.Show();
        }

    }
}
