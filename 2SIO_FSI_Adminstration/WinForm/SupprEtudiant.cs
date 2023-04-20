using _2SIO_FSI_Adminstration.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class SupprEtudiant : Form
    {
        Utilisateur utilisateur;
        Database database = new Database();
        List<Etudiant> etudiants = new List<Etudiant>();

        public SupprEtudiant(Utilisateur utilisateur1)
        {
            InitializeComponent();
            utilisateur = utilisateur1;
            refreshEtudiantList();
        }

        public void refreshEtudiantList()
        {
            cbListeEtudiant.Items.Clear();
            etudiants = database.getAllEtudiants();
            foreach (Etudiant etu in etudiants)
            {
                cbListeEtudiant.Items.Add(etu.getFullName());
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new Accueil(utilisateur);
            newForm.Show();
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            string etudiant = this.cbListeEtudiant.GetItemText(this.cbListeEtudiant.SelectedItem);
            if (etudiant != "")
            {
                foreach (Etudiant etu in etudiants)
                {
                    if(etudiant ==  etu.getFullName())
                    {
                        database.deleteEtudiant(etu.IdEtudiant);
                        MessageBox.Show("Etudiant " + etu.getFullName() + " supprimé avec succès !");
                        refreshEtudiantList();
                    }
                }
            } else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant !");
            }
        }
    }
}
