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
    public partial class ModifierEtudiant : Form
    {
        Utilisateur utilisateur;
        Database database = new Database();
        Etudiant mainEtu = new Etudiant();

        public ModifierEtudiant(Utilisateur util)
        {
            InitializeComponent();
            utilisateur = util;

            refreshListeEtudiants();

            List<Classe.Classe> classes = database.getAllClasses();
            foreach (Classe.Classe classe in classes)
                cbListeClasse.Items.Add(classe.LibelleClasse);
        }

        public void refreshListeEtudiants()
        {
            cbListeEtudiant.Items.Clear();
            List<Etudiant> etudiants = database.getAllEtudiants();
            foreach (Etudiant etu in etudiants)
            {
                cbListeEtudiant.Items.Add(etu.getFullName());
            }
        }

        private void bModify_Click(object sender, EventArgs e)
        {
            if (tbNumero.Text.Length == 10)
            {
                mainEtu.PrenomEtudiant = tbFirstName.Text;
                mainEtu.NomEtudiant = tbLastName.Text;
                mainEtu.MailEtudiant = tbMail.Text;
                mainEtu.NumeroEtudiant = tbNumero.Text;
                mainEtu.ClasseEtudiant = database.getClasseByLibelle(this.cbListeClasse.GetItemText(this.cbListeClasse.SelectedItem));

                database.modifyEtudiant(mainEtu);
                refreshListeEtudiants();
                MessageBox.Show("Etudiant " + mainEtu.getFullName() + " modifié avec succès !");

                tbFirstName.Enabled = false;
                tbLastName.Enabled = false;
                tbMail.Enabled = false;
                tbNumero.Enabled = false;
                cbListeClasse.Enabled = false;
            } else
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide !");
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAccueil = new Accueil(utilisateur);
            formAccueil.Show();
        }

        private void cbListeEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbFirstName.Enabled = true;
            tbLastName.Enabled = true;
            tbMail.Enabled = true;
            tbNumero.Enabled = true;
            cbListeClasse.Enabled = true;

            string etudiant = this.cbListeEtudiant.GetItemText(this.cbListeEtudiant.SelectedItem);
            List<Etudiant> etudiants = database.getAllEtudiants();
            foreach(Etudiant etu in etudiants)
            {
                if(etu.getFullName().Equals(etudiant))
                {
                    tbFirstName.Text = etu.PrenomEtudiant;
                    tbLastName.Text = etu.NomEtudiant;
                    tbMail.Text = etu.MailEtudiant;
                    tbNumero.Text = etu.NumeroEtudiant;
                    cbListeClasse.Text = etu.ClasseEtudiant.LibelleClasse;
                    mainEtu.IdEtudiant = etu.IdEtudiant;

                }
            }
        }
    }
}
