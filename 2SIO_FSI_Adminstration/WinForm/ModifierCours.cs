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
    public partial class ModifierCours : Form
    {
        Utilisateur utilisateur;
        Database database = new Database();
        Cours mainCours = new Cours();

        public ModifierCours(Utilisateur util)
        {
            InitializeComponent();
            utilisateur = util;

            refreshListCours();

            List<Classe.Classe> classes = database.getAllClasses();
            foreach (Classe.Classe classe in classes)
                cbListeClasse.Items.Add(classe.LibelleClasse);
        }

        public void refreshListCours()
        {
            cbListeCours.Items.Clear();
            List<Cours> listeCours = database.getAllCours();
            foreach (Cours cours in listeCours)
            {
                cbListeCours.Items.Add(cours.LibelleCours);
            }
        }

        private void bModify_Click(object sender, EventArgs e)
        {
            mainCours.LibelleCours = tbLibelleCours.Text;
            mainCours.DescriptionCours = tbDescriptionCour.Text;
            mainCours.ClasseCours = database.getClasseByLibelle(this.cbListeClasse.GetItemText(this.cbListeClasse.SelectedItem));

            database.modifyCours(mainCours);
            refreshListCours();
            MessageBox.Show("Cours " + mainCours.LibelleCours + " modifié avec succès !");
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAccueil = new Accueil(utilisateur);
            formAccueil.Show();
        }

        private void cbListeCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coursStr = this.cbListeCours.GetItemText(this.cbListeCours.SelectedItem);
            List<Cours> listeCours = database.getAllCours();
            foreach (Cours cours in listeCours)
            {
                if (cours.LibelleCours.Equals(coursStr))
                {
                    tbDescriptionCour.Text = cours.DescriptionCours;
                    tbLibelleCours.Text = cours.LibelleCours;
                    cbListeClasse.Text = cours.ClasseCours.LibelleClasse;
                    mainCours.IdCours = cours.IdCours;

                }
            }
        }
    }
}
