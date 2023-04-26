using _2SIO_FSI_Adminstration.Classe;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ModifierClasse : Form
    {
        Database database = new Database();
        Classe.Classe mainClasse = null;
        Utilisateur utilisateur;

        public ModifierClasse(Utilisateur util)
        {
            InitializeComponent();
            utilisateur = util;

            refreshListClasse();
        }

        public void refreshListClasse()
        {
            cbListeClasse.Items.Clear();
            List<Classe.Classe> coursList = database.getAllClasses();
            foreach (Classe.Classe classe in coursList)
            {
                cbListeClasse.Items.Add(classe.LibelleClasse);
            }
        }

        private void bModify_Click(object sender, EventArgs e)
        {
            mainClasse.LibelleClasse = tbLibelle.Text;
            mainClasse.AcronymeClasse = tbAcronyme.Text;
            MessageBox.Show("Classe " + mainClasse.LibelleClasse + " modifiée avec succès !");
            database.modifyClasse(mainClasse);
        }

        private void cbListeClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classeStr = this.cbListeClasse.GetItemText(this.cbListeClasse.SelectedItem);
            mainClasse = database.getClasseByLibelle(classeStr);

            tbAcronyme.Text = mainClasse.AcronymeClasse;
            tbLibelle.Text = mainClasse.LibelleClasse;

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAccueil = new Accueil(utilisateur);
            formAccueil.Show();
        }
    }
}
